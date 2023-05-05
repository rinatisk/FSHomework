module MapiRepeatTests

open FsUnit
open NUnit.Framework
open Test1.MapiRepeat

[<Test>]
let ``Should work correctly on the given example`` () =
    mapiRepeat 
    (fun index element -> index * element) 
    3 
    [1; 1; 1; 1] |> should equal [0; 1; 8; 27]
