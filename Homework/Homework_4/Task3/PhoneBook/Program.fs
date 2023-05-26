module Phonebook

let initPhoneBook() =
    Map.empty<string, string>

let addNumber name number phoneBook =
    Map.add name number phoneBook

let getNumberByName name phoneBook =
    Map.tryFind name phoneBook

let getNameByNumber number phoneBook =
    Map.tryFindKey (fun _ v -> v = number) phoneBook

let getAllRecords phoneNumber =
    Map.toList phoneNumber
    