namespace Task2

module Task2 =
    
    type Tree<'a> =
    | TreeNode of 'a * Tree<'a> * Tree<'a>
    | Empty
    
    let rec map func tree =
        match tree with
        | TreeNode(value, left, right) -> TreeNode(func value, map func left, map func right)
        | Empty -> Empty
        