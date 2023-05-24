module Homework1.task4
    
let powerOfTwoList m n =
    let rec powerOfTwoListRecursive m currentNumber acc =
                            match m with
                            | 0 -> currentNumber :: acc
                            | _ -> powerOfTwoListRecursive (m - 1) (currentNumber / 2) (currentNumber :: acc)
    powerOfTwoListRecursive m (pown 2 (m + n)) []
    
printf "%A" <| powerOfTwoList 5 4