module Task1.Test

open NUnit.Framework
open FsUnit
open Program

[<Test>]
let Test() =
    let empty = ""
    let incorrect = "(((())"
    let different = "(){}[]"
    isCorrect empty |> should equal true
    isCorrect incorrect |> should equal false
    isCorrect different |> should equal true
