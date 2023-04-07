namespace Network

open System.Collections.Generic

type TypeOS (name: string, VulnerabilityLevel: float) =
    member _.Name = name
    member _.VulnerabilityLevel = VulnerabilityLevel

type Computer =

    abstract member OS: TypeOS

    abstract member TryToInfect: unit -> unit
    
    abstract member IsInfected: bool

type Network (computers: Computer list, connectedComputers: IDictionary<Computer, Computer list>) =

    member _.UpdateState () =
        computers |> List.filter (fun c -> c.IsInfected)
                  |> List.map (fun c -> connectedComputers[c])
                  |> List.concat
                  |> List.iter (fun c -> c.TryToInfect())

        computers |> List.map (fun c -> c.IsInfected)

    member _.StopCondition () =
        computers |> List.exists (fun c -> c.IsInfected) |> not