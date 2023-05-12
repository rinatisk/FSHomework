module Workflow.Test.RoundingTests

open NUnit.Framework
open FsUnit

open Rounding


[<TestCase(0.0)>]
[<TestCase(1.0)>]
[<TestCase(3.3)>]
let RoundTest x =    
        let returned = RoundingBuilder 3 {
            let! y = x 
            return y
        }
        returned |> should equal x
