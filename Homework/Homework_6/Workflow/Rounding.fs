module Rounding

type RoundingBuilder(digits: int) =
    member this.Bind (value: float, f) =
        (value, digits) |> System.Math.Round |> f
    member this.Return (value: float) =
        System.Math.Round (value, digits)
        