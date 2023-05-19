module Task1.Test

open NUnit.Framework
open FsUnit
open BracketsChecker


[<Test>]
let TestEmpty() =
    let empty = ""
    isCorrect empty |> should equal true
   
[<Test>]    
let TestCorrect() =
    let different = "(){}[]"
    BracketsChecker.isCorrect different |> should equal true
    
[<Test>]
let TestIncorrect() =
    let incorrect = "(((())"
    isCorrect incorrect |> should equal false

