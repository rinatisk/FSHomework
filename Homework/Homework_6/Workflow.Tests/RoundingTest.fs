module Workflow.Test.RoundingTests

open NUnit.Framework
open FsUnit

open Rounding

let rounding = RoundingBuilder


[<TestCase(0.0)>]
[<TestCase(1.0)>]
[<TestCase(-21.43)>]
[<TestCase(System.Double.NaN)>]
[<TestCase(System.Double.PositiveInfinity)>]
[<TestCase(System.Double.NegativeInfinity)>]
let RoundTest x =    
        let returned = rounding 3 {
            let! y = x 
            return y
        }
        returned |> should equal x
