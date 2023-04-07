module Test

open NUnit.Framework
open FsUnit
open Network
open System.Collections.Generic

module Tests =
    type AlwaysInfectComputer() =
        let mutable isInfected = false
        
        interface Computer with
            member _.OS = TypeOS("Linux", 0.0)
            member _.TryToInfect() = isInfected <- true
            member _.IsInfected
                with get() = isInfected

    type NeverInfectComputer() =
        let mutable isInfected = false

        interface Computer with
            member _.OS = TypeOS("Linux", 1.0)
            member _.TryToInfect () = ()
            member _.IsInfected
                with get() = isInfected
                
    let createNetwork (a: Computer) (b: Computer list) (c: Computer list) =


        let connections = Dictionary<Computer, Computer list>()

        connections.Add (a, b)

        connections.Add (b.[0], [a; b.[1]; c.[0]])
        connections.Add (b.[1], [a; b.[0]; c.[1]; c.[2]])

        connections.Add (c.[0], [b.[0]])
        connections.Add (c.[1], [b.[1]])
        connections.Add (c.[2], [b.[1]])

        let computers = [a::b; c] |> List.concat

        Network(computers, connections)