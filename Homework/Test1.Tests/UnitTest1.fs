module SupermapTests

open FsUnit
open NUnit.Framework
open Test1.Supermap

[<Test>]
let EmptyTListTest() =
    supermap id list.Empty |> should equal list.Empty

[<Test>]
let SimpleTest () =
    supermap (fun x -> [sin x; cos x]) [1.0; 2.0; 3.0] |> should equal [sin 1.0; cos 1.0; sin 2.0; cos 2.0; sin 3.0; cos 3.0]