module Homework1.task1

let rec factorial x =
    match x with
    | 0 -> 1
    | n -> n * factorial (n - 1)
    
printf "%i" <| factorial(6)
    