module BracketsChecker
let brackets = Map ['(',')';'[',']';'{','}']
let isCorrect (input: string) = 
    let rec isCorrectRec str stack =
        match str, stack with
        | [], [] -> true
        | [], _ -> false
        | h :: t, _ when brackets.Keys |> Seq.contains h -> isCorrectRec t (h::stack)
        | h :: t, h2 :: t2 when brackets.Values |> Seq.contains h && brackets.TryFind h = Some h2 -> isCorrectRec t t2
        | _ :: t, _ -> isCorrectRec t stack 
    isCorrectRec (Seq.toList input) []
