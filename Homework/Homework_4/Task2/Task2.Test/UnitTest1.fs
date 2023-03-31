module Task2.Test

open NUnit.Framework
open FsCheck
open Program

[<Test>]
let Test() =
    Check.QuickThrowOnFailure (fun a b -> func1 a b = func2 a b)
    Check.QuickThrowOnFailure (fun a b -> func2 a b = func3 a b)
    Check.QuickThrowOnFailure (fun a b -> func3 a b = func4 a b)
    Check.QuickThrowOnFailure (fun a b -> func1 a b = func4 a b)