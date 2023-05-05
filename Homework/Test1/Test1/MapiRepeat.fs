module MapiRepeat
    let mapiRepeat mapping n inputList =
        let repeat n fn = List.init n (fun _ -> fn) |> List.reduce (>>)
        if n < 0 then
            failwith "N < 0"
        match n with
        | 0 -> inputList
        | _ -> inputList |> repeat n (List.mapi mapping)
        
