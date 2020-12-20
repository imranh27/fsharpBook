
//17.3 Sets

let myBasket = ["Apples"; "Apples"; "Apples"; "Bananas"; "Pineapples" ]
let fruitILike = myBasket |> Set.ofList


let yourBasket = [ "Kiwi"; "Bananas"; "Grapes" ]

let allFruitList = ( fruits & otherFruits) |> List.distinct

let fruitsYouLike = yourBasket |> Set.ofList
let allFruits = fruitILike + fruitsYouLike

let fruitsJustForMe = allFruits - fruitsYouLike

let fruitsWeCanShare = fruitILike |> Set.intersect fruitsYouLike

let doILikeAllYourFruits = fruitILike |> Set.isSubset fruitsYouLike





