open System

type colors =
    | red = 1
    | blue = 2
    | green = 3
    | purple = 4

let main argv =
    let color = colors.red
    let response = match color with
    | red -> "Kırmızı"
    | blue -> "Mavi"
    | green -> "Yeşil"
    | purple -> "Mor"
    printfn "%s" response