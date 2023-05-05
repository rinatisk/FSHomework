module MapiRepeat
    let mapiRepeat mapping n inputList =
        let repeat n fn = List.init n (fun _ -> fn) |> List.reduce (>>)
        inputList |> repeat n (List.mapi mapping)
