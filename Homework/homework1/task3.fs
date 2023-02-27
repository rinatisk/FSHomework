module Homework1.task3

let rec reverseListRecursive currentList acc =
    match currentList with
    | [] ->  acc
    | head::tail -> reverseListRecursive tail (head::acc)

let rec reverseList list =
    reverseListRecursive list []
    
printf "%A" <| reverseList [1 .. 10]
