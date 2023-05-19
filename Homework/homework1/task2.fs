module Homework1.task2

let fibonacci n =
    let rec fibonacciRecursive n current previous =
                     match n with
                     | 0 -> previous
                     | 1 -> current
                     | n -> fibonacciRecursive (n - 1) (current + previous) current
    fibonacciRecursive n 0 1
    
printf "%i" <| fibonacci 6
