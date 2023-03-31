    let func1 x list =
        List.map (fun y -> y * x) list

    let func2 x =
        List.map (fun y -> y * x)

    let func3 x =
        List.map ((*) x)

    let func4 =
        List.map << (*)