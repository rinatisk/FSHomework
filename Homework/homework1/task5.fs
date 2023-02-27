module Homework1.task5

let rec findFirstElementListRecursive counter element list =
    match list with
    | [] -> -1
    | head::_ when head = element -> counter
    | _::tail -> findFirstElementListRecursive (counter + 1) element tail
    
let rec findFirstElementList element list =
    findFirstElementListRecursive 0 element list

printf "%i" <| findFirstElementList 7 [1 .. 10]