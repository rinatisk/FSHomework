module BracketsChecker
let brackets = Map ['}', '{'; ')', '('; ']', '[']
let isCorrect str =
    let rec isCorrectRecursive str (stack: char list) =
        match str with
        | [] -> stack.IsEmpty
        | h :: t when brackets.Values.Contains h -> isCorrectRecursive t (h :: stack)
        | h :: t when brackets.Keys.Contains h ->
            match stack with
            | [] -> false
            | h2 :: t2 when h2 = brackets[h] -> isCorrectRecursive t t2
            | _ -> false
        | _ :: t -> isCorrectRecursive t stack
    isCorrectRecursive (Seq.toList str) []
