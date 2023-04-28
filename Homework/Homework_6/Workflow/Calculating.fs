﻿module Calculating

type CalculateBuilder() =
    member this.Bind (value : string, result) =
        match System.Int32.TryParse value with
        | (true, number) -> number |> result
        | _ -> "NaN"
    member this.Return (value : int) =
        value.ToString()