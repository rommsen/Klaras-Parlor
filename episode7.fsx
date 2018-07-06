let icecreamShop = "Klaras Parlor"

type SpecialFlavour =
  | RedRising
  | CreamDream

type Flavour =
  | Strawberry
  | Vanilla
  | Special of SpecialFlavour

let rec priceFor flavour =
  match flavour with
  | Strawberry ->
      1.1

  | Vanilla ->
      0.9

  | Special RedRising ->
      (priceFor Strawberry) + 0.2

  | Special CreamDream ->
      (priceFor Vanilla) + 0.2


let sales =
  [
    Special RedRising
    Special RedRising
    Special CreamDream
    Special RedRising
    Special CreamDream
    Special RedRising
    Strawberry
  ]

sales
|> List.map priceFor
|> List.sum