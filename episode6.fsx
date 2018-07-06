let icecreamShop = "Klaras Parlor"

type SpecialFlavour =
  | RedRising
  | CreamDream

type Flavour =
  | Strawberry
  | Vanilla

let dayResults sold price  =
  sold * price

let priceFor flavour =
  match flavour with
  | Strawberry ->
      1.1

  | Vanilla ->
      0.9

let resultsFor ice sold =
  ice
  |> priceFor
  |> dayResults sold

let iceFor ice =
  match ice with
  | RedRising ->
      Strawberry

  | CreamDream ->
      Vanilla

let priceForSpecial  =
  iceFor >> priceFor

let sales =
  [
    RedRising
    RedRising
    CreamDream
    RedRising
    CreamDream
    RedRising
    Strawberry
  ]

sales
|> List.map priceForSpecial
|> List.sum