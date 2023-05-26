module PhoneBook.Tests

open NUnit.Framework
open FsUnit
open Phonebook

[<Test>]
let InitTest() =
    let phoneList = initPhoneBook()
    phoneList |> should equal Map.empty<string, string>

[<Test>]
let addNumberTest() =
    let phoneList = initPhoneBook()
    let phoneList1 = phoneList |> addNumber "test" "111"
    let phoneList2 = phoneList1 |> addNumber "test2" "111111"
    let expectedMap = Map.ofList [("test", "111"); ("test2", "111111")]
    phoneList2 |> should equal expectedMap

[<Test>]
let FindPhoneTest() =
    let phoneList = initPhoneBook()
    let phoneList1 = phoneList |> addNumber "test" "111"
    let phoneList2 = phoneList1 |> addNumber "test2" "111111"
    let phone = phoneList2 |> getNumberByName "test"
    phone.Value |> should equal "111"

[<Test>]
let FindNameTest() =
    let phoneList = initPhoneBook()
    let phoneList1 = phoneList |> addNumber "test" "111"
    let phoneList2 = phoneList1 |> addNumber "test2" "111111"
    let name = phoneList2 |> getNameByNumber "111"
    name.Value |> should equal "test"
