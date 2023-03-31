module Task3.Test

open NUnit.Framework
open FsUnit
open Task3

[<Test>]
let test1 () =
    let theInnermostRightTerm =
            Application(Abstraction("x", Application(Application(Variable("x"), Variable("y")), Variable("x"))), Variable("y"))
    let theInnermostLeftTerm =
            Application(Variable("x"), Variable("z"))
    let bigLeftTerm =
            Abstraction("x", Abstraction("y", Abstraction("z", Application(theInnermostLeftTerm, theInnermostRightTerm))))
    let mainTerm = 
            Application(Application(bigLeftTerm ,Variable("y")), Abstraction("x", Variable("x")))

    let expected = Application (Abstraction("a", Abstraction("a9857",Application
            (Application (Variable "y", Variable "a9857"),
            Application (Application (Variable "a", Variable "a"), Variable "a")))), Abstraction ("x", Variable "x"))

    mainTerm |> betaReduce |> should equal expected
    