namespace Task4

module Task4 =
    let getInfinitePrimeSeq() =
        let isPrime n =
            let max = float n |> sqrt |> int
            [2 .. max] |> List.exists (fun e -> n % e = 0) |> not
        (+) 2 |> Seq.initInfinite |> Seq.filter isPrime
        