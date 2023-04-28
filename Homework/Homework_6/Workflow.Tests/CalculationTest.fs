module Workflow.Tests.CalculationTest

open NUnit.Framework
open FsUnit
open FsCheck

let calculate = Calculating.CalculateBuilder()

[<Test>]
let ReturnTest () =
    Check.QuickThrowOnFailure (fun s ->
        let returned = calculate {
            return s
        }
        System.Int32.Parse returned = s)


[<Test>]
let BindTest () =    
    Check.QuickThrowOnFailure (fun x ->
        let returned = calculate {
            let! i = x 
            return i
        }
        returned = x)
