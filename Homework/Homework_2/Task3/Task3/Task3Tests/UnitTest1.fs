module Task3Tests

open NUnit.Framework
open Task3.Task3
open FsUnit

let test_cases () =
    [
        Number(0), 0
        Multiplication(Addition(Number(0), Number(100)), Number(2)), 200
        Division(Subtraction(Number(42), Number(7)), Subtraction(Number(100), Number(99))), 35
    ] |> List.map (fun (expression, result) -> TestCaseData(expression, result))

[<Test>]
let dividingByZero () =
    (fun () -> compute (Division(Number(1), Number(0))) |> ignore) 
        |> should throw typeof<System.InvalidOperationException>


[<TestCaseSource(nameof test_cases)>]
let simpleTests expression result =
    compute expression |> should equal result