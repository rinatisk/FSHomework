namespace Task1

module Task1 =

    let countEvenSumBy list =
        list |> List.sumBy (fun element -> (abs element + 1) % 2)

    let countEvenFilter list =
        list |> List.filter (fun element -> element % 2 = 0) |> List.length

    let countEvenFold list =
        List.fold (fun acc element -> (abs element + 1) % 2 + acc) 0 list