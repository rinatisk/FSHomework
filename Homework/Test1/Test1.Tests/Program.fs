module MapiRepeatTests

open FsUnit
open NUnit.Framework
open Test1.MapiRepeat

[<Test>]
let SimpleTest () =
    mapiRepeat 
    (fun index element -> index * element) 
    3 
    [1; 1; 1; 1] |> should equal [0; 1; 8; 27]
    
let ZeroTest () =
    mapiRepeat 
    (fun index element -> index * element) 
    0 
    [1; 1; 1; 1] |> should equal [1; 1; 1; 1]
