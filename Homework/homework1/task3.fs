module Homework1.task3

let reverseList list =
    let rec reverseListRecursive currentList acc =
                          match currentList with
                          | [] ->  acc
                          | head :: tail -> reverseListRecursive tail (head :: acc)
    reverseListRecursive list []
    
printf "%A" <| reverseList [1 .. 10]
