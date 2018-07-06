let icecreamShop = "Klaras Parlor"

let resultOfDay (numberOfScoopsSold : float) : float =
  numberOfScoopsSold * 0.9

resultOfDay 23.
resultOfDay 42.
resultOfDay 75.

let dayResults sold price : float =
  sold * price

dayResults 42. 0.9
dayResults 42. 1.0
dayResults 42. 1.1
