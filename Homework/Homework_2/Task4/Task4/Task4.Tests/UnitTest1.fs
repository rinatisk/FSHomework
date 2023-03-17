module Task4.Tests

open NUnit.Framework
open FsUnit
open Task4.Task4

[<Test>]
let getFirstTenPrimeNumbersTest () =
    let expected = seq { 2; 3; 5; 7; 11; 13; 17; 19; 23; 29 }
    getInfinitePrimeSeq () |> Seq.take 10  |> should equal expected