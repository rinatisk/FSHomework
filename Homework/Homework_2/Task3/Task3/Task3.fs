namespace Task3

module Task3 =
    
    type Tree =
    | Number of int
    | Addition of Tree * Tree
    | Multiplication of Tree * Tree
    | Subtraction of Tree * Tree
    | Division of Tree * Tree
    
    let rec compute tree =
        match tree with
        | Number n -> n
        | Addition(tree1, tree2) -> compute tree1 + compute tree2
        | Multiplication(tree1, tree2) -> compute tree1 * compute tree2
        | Subtraction(tree1, tree2) -> compute tree1 - compute tree2
        | Division(tree1, tree2) when compute tree2 <> 0 -> compute tree1 / compute tree2
        | _ -> invalidOp("Dividong by zero")
        