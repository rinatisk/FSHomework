module Homework1.task5

let findFirstElementList element list =
    let rec findFirstElementListRecursive counter element list =
                                           match list with
                                           | [] ->  None
                                           | head :: _ when head = element -> Some counter
                                           | _ :: tail -> findFirstElementListRecursive (counter + 1) element tail
    findFirstElementListRecursive 0 element list

printf "%A" <| findFirstElementList 7 [1 .. 10]