open System

let brackets = Map [('(',')');('[',']');('{','}')]
let isCorrect (input: string) = 
    let rec isCorrectRec leftPart rightPart =
        match leftPart, rightPart with
        | [], [] -> true
        | _::_, [] -> false
        | _, h::t when Map.keys brackets |> Seq.contains h -> isCorrectRec (h::leftPart) t
        | h::t, h2::t2 when Map.values brackets |> Seq.contains h2 && Map.find h brackets = h2 -> isCorrectRec t t2
        | _, h::_ when Map.values brackets |> Seq.contains h -> false
        | _, _::t -> isCorrectRec leftPart t
    isCorrectRec (Seq.toList input) []
