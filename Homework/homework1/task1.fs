module Homework1.task1

let rec fibonacciNaive n =
    match n with
    | 0 | 1 -> 1
    | n -> fibonacciNaive (n - 1) + fibonacciNaive (n - 2)
    
printf "%i" <| fibonacciNaive(6)
    