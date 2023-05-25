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
    isCorrect different |> should equal true
    
[<Test>]
let TestIncorrect() =
    let incorrect = "(((())"
    isCorrect incorrect |> should equal false
    
[<Test>]
let TestWithoutBrackets() =
    let correct = "qwerty"
    isCorrect correct |> should equal true
    
[<Test>]
let TestWithBracketsFalse() =
    let incorrect = "((qwerty(}]"
    isCorrect incorrect |> should equal false
    
[<Test>]
let TestWithBracketsTrue() =
    let correct = "(([q]w))er{ty}()"
    isCorrect correct |> should equal true

