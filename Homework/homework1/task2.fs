module Homework1.task2

let rec fibonacciRecursive n current previous =
    match n with
    | 0 -> previous
    | 1 -> current
    | n -> fibonacciRecursive (n - 1) (current + previous) current

let rec fibonacci n =
    fibonacciRecursive n 1 1
    
printf "%i" <| fibonacci 6
