module MapiRepeat
    let mapiRepeat mapping n inputList =
        let repeat n fn = List.init n (fun _ -> fn) |> List.reduce (>>)
        match n with
        | 0 -> inputList
        | _ -> inputList |> repeat n (List.mapi mapping)
        
