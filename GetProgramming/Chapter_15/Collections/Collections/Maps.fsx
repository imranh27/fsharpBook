

//Lesson 17, Maps, Dictionaries and Sets

//17.1

open System.Collections.Generic
let inventory = Dictionary<string, float>()

inventory.Add("Apples", 0.33)
inventory.Add("Oranges", 0.23)
inventory.Add("Bananas", 0.45)

inventory.Remove "Oranges"
let bananas = inventory.["Bananas"]

//generic type inference
let inventory2 = Dictionary<_,_>()
inventory2.Add("Apples", 0.33)

let inventory3 = Dictionary()
inventory3.Add("Apples", 0.33)

//immutable dictionaries
let inventory4 : IDictionary<string, float> =                
    [ "Apples", 0.33; "Oranges", 0.23; "Bananas", 0.45 ]    
    |> dict

let bananas4 = inventory4.["Bananas"]


let inventory5 =
    ["Apples", 0.33; "Oranges", 0.23; "Bananas", 0.45]
    |> Map.ofList
    
let apples5 = inventory5.["Apples"]


let newInventory5 =
    inventory5
    |> Map.add "Pineapples" 0.87
    |> Map.remove "Apples"
    
let cheapFruit, expensiveFruit =
    inventory5
    |> Map.partition(fun fruit cost -> cost < 0.3)
 


