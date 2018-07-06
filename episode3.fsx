let icecreamShop = "Klaras Parlor"
open System.Drawing

let dayResults sold price : float =
  sold * price

let priceFor flavour =
  if flavour = "Strawberry" then
    1.1
  else
    0.9

dayResults 50. (priceFor "Strawberry")

let strawberryResult =
  "Strawberry"
  |> priceFor
  |> dayResults 50.

let vanillaResult =
  "Vanilla"
  |> priceFor
  |> dayResults 100.

strawberryResult + vanillaResult

let resultsFor ice sold =
  ice
  |> priceFor
  |> dayResults sold

resultsFor "Strawberry" 100. + resultsFor "Vanilla" 50.