module Homework1.task4

let rec powerOfTwoListRecursive m n acc list =
    match m with
    | 0 -> acc::list
    | _ -> powerOfTwoListRecursive (m - 1) n (acc / 2) (acc::list)
    
let rec powerOfTwoList m n =
    powerOfTwoListRecursive m n (pown 2 (m + n)) []
    
printf("%A") <| powerOfTwoList 5 4