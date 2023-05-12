module Rounding

type RoundingBuilder(digits: int) =
    member this.Bind (value: float, f) =
        (value, digits) |> System.Math.Round |> f
    member this.Return (value: float) =
        (value, digits) |> System.Math.Round
        