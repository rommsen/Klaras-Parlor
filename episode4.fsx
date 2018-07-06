let icecreamShop = "Klaras Parlor"

let dayResults sold price  =
  sold * price

let priceFor ice =
  if ice = "Strawberry" then
    0.9
  else
    1.1

let resultsFor ice sold =
  ice
  |> priceFor
  |> dayResults sold

let iceFor flavour =
  if flavour = "Red Rising" then
    "Strawberry"
  else
    "Vanilla"


"Red Rising"
|> iceFor
|> priceFor
|> dayResults 50.

let priceForSpecial flavour =
  flavour
  |> iceFor
  |> priceFor

let priceForSpecialComp =
  iceFor >> priceFor

"Red Rising"
|> priceForSpecialComp
|> dayResults 50.