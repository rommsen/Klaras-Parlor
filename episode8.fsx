let icecreamShop = "Klaras Parlor"

type SpecialFlavour =
  | RedRising
  | CreamDream

type Flavour =
  | Strawberry
  | Vanilla
  | Special of SpecialFlavour

type Size =
  | Small
  | Medium
  | Large

type IceSold =
  {
    Flavour : Flavour
    Size : Size
  }

{
  Flavour = Strawberry
  Size = Large
}

let sold flavour =
  {
    Flavour = flavour
    Size = Medium
  }

let vanilla =
  sold Vanilla

{ vanilla with Size = Large }

vanilla

let updateSize iceSold size =
  { iceSold with Size = size }

let withSize size iceSold =
  { iceSold with Size = size}

updateSize vanilla Small

updateSize (sold Strawberry) Large

Strawberry |> sold  |> withSize Large



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

let multiplierFor size =
  match size with
  | Small ->
      0.7

  | Medium ->
      1.0

  | Large ->
      1.3

let sales =
  [
    Special RedRising |> sold |> withSize Large
    Special RedRising |> sold |> withSize Small
    Special CreamDream |> sold |> withSize Medium
    Special RedRising |> sold |> withSize Small
    Special CreamDream |> sold |> withSize Large
    Strawberry |> sold |> withSize Medium
  ]

let totalResult iceSold =
  (iceSold.Flavour |> priceFor) * (iceSold.Size |> multiplierFor)

sales
|> List.map totalResult
|> List.sum