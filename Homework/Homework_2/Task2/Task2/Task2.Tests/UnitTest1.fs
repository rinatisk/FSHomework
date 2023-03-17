module Task2.Tests

open NUnit.Framework
open Task2.Task2
open FsUnit

[<Test>]
let emptyTreeTest () =
    map id Tree.Empty |> should equal (Tree.Empty)

[<Test>]
let idTest () =
    let tree = TreeNode(1, TreeNode(2, Tree.Empty, Tree.Empty), TreeNode(3, Tree.Empty, Tree.Empty))
    map id tree |> should equal tree

[<Test>]
let multiplyTest () =
    let tree = TreeNode(10, TreeNode(200, Tree.Empty, Tree.Empty), TreeNode(300, Tree.Empty, Tree.Empty))
    let func x = x * 100
    let expected = TreeNode(1000, TreeNode(20000, Tree.Empty, Tree.Empty), TreeNode(30000, Tree.Empty, Tree.Empty))
    map func tree |> should equal expected