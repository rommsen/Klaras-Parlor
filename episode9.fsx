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

type Weekday =
  | Monday
  | Tuesday
  | Wednesday
  | Thursday
  | Friday
  | Saturday
  | Sunday

type IceSold =
  {
    Flavour : Flavour
    Size : Size
    Weekday : Weekday
  }

type OnSale =
  {
    Flavour : Flavour
    Weekday : Weekday
    Factor : float
  }


let onSale weekday flavour =
  {
     Flavour = flavour
     Weekday = weekday
     Factor = 0.5
  }

let withSize size iceSold =
  { iceSold with Size = size }

let sold weekday flavour =
  {
    Flavour = flavour
    Size = Medium
    Weekday = weekday
  }

let onMonday =
  sold Monday

let onTuesday =
  sold Tuesday

let onWednesday =
  sold Wednesday

onMonday Strawberry
onTuesday Strawberry
onWednesday Strawberry

let priceMultiplier size =
  match size with
  | Small ->
      0.7

  | Medium ->
      1.0

  | Large ->
      1.3


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

let onSalePerWeek1 =
  [
    Strawberry |> onSale Monday
    Special RedRising |> onSale Monday
    Special CreamDream |> onSale Wednesday
    Special RedRising |> onSale Wednesday
  ]

let onSalePerWeek2 =
  [
    Strawberry |> onSale Wednesday
    Special CreamDream |> onSale Monday
    Special RedRising |> onSale Thursday
  ]


let sales =
  [
    Strawberry |> onMonday |> withSize Medium
    Special RedRising |> onMonday |> withSize Large
    Special RedRising |> onMonday |> withSize Small
    Special CreamDream |> onWednesday |> withSize Large
    Special RedRising |> onWednesday |> withSize Small
  ]

let totalPrice (onSales : OnSale list) (iceSold : IceSold) =
  let onSale =
    onSales |> List.find (fun onSale -> onSale.Flavour = iceSold.Flavour && onSale.Weekday = iceSold.Weekday)

  priceFor iceSold.Flavour * priceMultiplier iceSold.Size * onSale.Factor

sales
|> List.map (totalPrice onSalePerWeek1)
|> List.sum

sales
|> List.map (totalPrice onSalePerWeek2)
|> List.sum


