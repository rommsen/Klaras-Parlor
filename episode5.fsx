let icecreamShop = "Klaras Parlor"

let dayResults sold price  =
  sold * price

let priceFor ice =
  if ice = "Strawberry" then
    1.1
  else
    0.9
let resultsFor ice sold =
  ice
  |> priceFor
  |> dayResults sold

let iceFor ice =
  if ice = "Red Rising" then
    "Strawberry"
  else
    "Vanilla"

let priceForSpecial  =
  iceFor >> priceFor

let sales =
  [
    "Red Rising"
    "Red Rising"
    "Cream Dream"
    "Red Rising"
    "Cream Dream"
    "RedRising"
  ]

 // map each element of the list to a price
 // List.map : (string -> float) -> string list -> float list
sales
|> List.map priceForSpecial
 // sum all the elements in the list
|> List.sum

sales
|> List.filter (fun flavour -> flavour = "Red Rising")
|> List.map priceForSpecial
|> List.sum

sales
|> List.filter (fun flavour -> flavour = "Red Rising")
|> List.map priceForSpecial
|> List.map (fun x -> x + 0.2)
|> List.sum

sales
|> List.filter (fun flavour -> flavour = "Cream Dream")
|> List.length