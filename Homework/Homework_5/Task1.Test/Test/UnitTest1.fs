module Test

open NUnit.Framework
open FsUnit
open Network
open System.Collections.Generic

module Tests =
    
    let AlwaysInfectedOS = TypeOS("Linux", 1l)
    
    let AlwaysInfectedComputer = Computer(AlwaysInfectedOS)
    AlwaysInfectedComputer.TryToInfect()
    
    let NeverInfectedOS = TypeOS("Win10", 0l)
    
    let NeverInfectedComputer = Computer(NeverInfectedOS)
    
    [<Test>]
    let AllInfectedTest() =
        let AlwaysInfectedComputer1 = Computer(AlwaysInfectedOS)
        AlwaysInfectedComputer1.TryToInfect()
        
        let AlwaysInfectedComputer2 = Computer(AlwaysInfectedOS)
        let AlwaysInfectedComputer3 = Computer(AlwaysInfectedOS)
        
        let dict1 = Dictionary<Computer, Computer list>()
        dict1.Add(AlwaysInfectedComputer1, [AlwaysInfectedComputer2; AlwaysInfectedComputer3])
        
        let Network = Network([AlwaysInfectedComputer1; AlwaysInfectedComputer2; AlwaysInfectedComputer3], dict1)
        Network.UpdateState() |> should equal [true; true; true]
                        