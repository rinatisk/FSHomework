module Rhombus =
    let print n =
        let rec printDownRecursive string total current =
            if current = 1 then
                string + String.replicate (total - 2) " " + "*" + String.replicate (total - 2) " " + "\n"
            else
                printDownRecursive (string + String.replicate (total - current - 1) " " + "*" + String.replicate (current * 2 + 2 - total) " " + "*" + String.replicate (total - current - 1) " " + "\n") total (current - 1)
        
        if (n > 1) then
            printDownRecursive (printDownRecursive "" n (n - 1) |> Seq.rev |> System.String.Concat) n (n - 1)
            
        else if (n = 1) then
                "*"
            else
                " "
