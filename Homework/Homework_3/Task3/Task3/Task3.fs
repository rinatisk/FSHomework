module Task3

type LambdaTerm =
| Variable of string
| Application of LambdaTerm * LambdaTerm
| Abstraction of string * LambdaTerm

let rec betaReduce expression =
    let rec getFreeVariables term =
        match term with
        | Variable name -> set [name]
        | Application (leftTerm, rightTerm) -> Set.union (getFreeVariables leftTerm) (getFreeVariables rightTerm)
        | Abstraction (variable, term) -> getFreeVariables term |> Set.remove variable
    
    let isVariableFree variable term =
        getFreeVariables term |> Set.contains variable
    
    let getNextChar (current: string) =
        match current[String.length current - 1] with
        | 'z' -> current + "a"
        | char -> current + string (int char + 1)
        
    let alphaConverse set =
        let rec getNewName current =
            match current with
            | current when set |> Set.contains current -> getNextChar current |> getNewName
            | _ -> current
        getNewName "a"
    
    let rec substitute toSubstituteTerm variable term =
        match toSubstituteTerm with
        | Variable str when str = variable -> term
        | Variable _ -> toSubstituteTerm
        | Application (leftTerm, rightTerm) -> Application (substitute leftTerm variable term, substitute rightTerm variable term)
        | Abstraction (str, _) when str = variable -> toSubstituteTerm
        | Abstraction (var, innerTerm) when isVariableFree var innerTerm |> not || isVariableFree variable innerTerm |> not ->
            Abstraction (var, substitute innerTerm variable term)
        | Abstraction (var, innerTerm) ->
            let conversedVar = Set.union (getFreeVariables innerTerm) (getFreeVariables term) |> alphaConverse
            Abstraction (conversedVar, substitute ((Variable conversedVar) |> substitute innerTerm var) variable term)                      
        
        
    match expression with
    | Variable _ -> expression
    | Abstraction(variable, term) -> Abstraction(variable, betaReduce term)
    | Application(Abstraction(variable, innerTerm), term) -> substitute innerTerm variable term |> betaReduce
    | Application(leftTerm, rightTerm) -> Application(betaReduce leftTerm, betaReduce rightTerm)
    