module Supermap
let supermap func list =
    List.map func list |> List.concat