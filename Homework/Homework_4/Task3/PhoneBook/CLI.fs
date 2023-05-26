module PhoneBook.CLI

open System
open Phonebook
open System.IO

let readNumbersFromFile file phoneBook =
    let newNumbers = File.ReadAllLines(file) |> Array.toList |> List.map (fun s -> ((s.Split ":")[0], (s.Split ":")[1]))
    Map.ofList ((phoneBook |> getAllRecords) @ newNumbers)

let writeNumbersToFile file phoneBook =
    let numbers = phoneBook |> getAllRecords |> List.map(fun (k, v) -> k + v)
    File.WriteAllLines(file, numbers)

let printBook phoneBook =
    phoneBook |> getAllRecords |> List.map (fun (k, v) -> k + v) |> List.map(fun s -> printf $"{s}")

let main() =
    printfn "
             0 /// exit
             1 /// Add *name* *phone*
             2 /// ReadFromFile *file*
             3 ///  WriteToFile *filename*
             4 /// GetNumber *name*
             5 /// GetPhone *number*
             6 /// PrintAllRecords"

    let phoneBook = initPhoneBook()

    let rec executionLoop phoneBook =
        let args = Console.ReadLine().Split " "
        let command = args[0]
        match command with
            | "0" -> true
            | "1" ->
                let name = args[1]
                let phone = args[2]
                addNumber name phone phoneBook |> ignore
                executionLoop phoneBook
            | "2" ->
                let file = args[1]
                readNumbersFromFile file phoneBook |> ignore
                executionLoop phoneBook
            | "3" ->
                let file = args[1]
                writeNumbersToFile file phoneBook
                executionLoop phoneBook
            | "4" ->
                let name = args[1]
                let number = getNumberByName name phoneBook
                match number with
                | Some number -> printf $"Phone:{number}"
                | None -> printf "No phone in phoneBook"
                executionLoop phoneBook
            | "5" ->
                let phone = args[1]
                let name = getNameByNumber phone phoneBook
                match name with
                | Some name -> printf $"Name:{name}"
                | None -> printf "No name in phoneBook"
                executionLoop phoneBook
            | "6" ->
                printBook phoneBook |> ignore
                executionLoop phoneBook
            | _ ->
                executionLoop phoneBook

    executionLoop phoneBook

main() |> ignore