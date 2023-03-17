module Task1.Tests

open NUnit.Framework
open Task1.Task1
open FsUnit
open FsCheck

let test_cases () = 
    [
        [], 0
        [2; 2; 2], 3
        [1; 1; 1], 0
        [1 .. 10], 5
        [1 .. 100], 50 
    ] |> List.map (fun (list, count) -> TestCaseData(list, count))

[<TestCaseSource(nameof test_cases)>]
let countEvenSumByTest list expected =
    countEvenSumBy list |> should equal expected

[<TestCaseSource(nameof test_cases)>]
let countEvenFilterTest list expected =
    countEvenFilter list |> should equal expected

[<TestCaseSource(nameof test_cases)>]
let countEvenFoldTest list expected =
    countEvenFold list |> should equal expected

let checkEquivalentFunction (list: list<int>) =
    countEvenFilter list = countEvenSumBy list && countEvenFold list = countEvenSumBy list

[<Test>]
let functionEquivalenceTest () =
    Check.QuickThrowOnFailure checkEquivalentFunction