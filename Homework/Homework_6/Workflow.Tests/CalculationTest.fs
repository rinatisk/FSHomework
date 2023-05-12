module Workflow.Tests.CalculationTest

open NUnit.Framework
open FsUnit
open FsCheck


[<Test>]
let FailureTest () =
    Check.QuickThrowOnFailure (fun s ->
        let returned = Calculating.CalculateBuilder() {
            return s
        }
        System.Int32.Parse returned = s)


[<Test>]
let CalculateTest () =    
    let returned = Calculating.CalculateBuilder() {
        let! x = "1"
        let! y = "2"
        let z = x + y
        return z
    }
    returned |> should equal "3"


