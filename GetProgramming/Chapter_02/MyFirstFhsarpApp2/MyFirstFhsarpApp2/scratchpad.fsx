

let text = "Hello World"
text.Length





let greetPerson name age = 
    sprintf "Hello %s, you are %d years old" name age

let greeting = greetPerson "Fred" 25



let firstName = "Imran"
let random = System.Random


let whoami firstName = 
    sprintf "You are %s" firstName


let introduce = whoami firstName



//5.2 Type Inference
let add a b = 
    let answer = a + b
    answer

          
let getLength (name:string) = sprintf "Name is %d letters." name.Length 
let foo(name) = "Hello! " + getLength(name)       



let sayHello someValue = 
    let innerFunction number = 
        if number > 10 then "Isaac"
        elif number > 20 then "Fred"
        else "Sara"

    let resultOfInner = 
        if someValue < 10.0 then innerFunction 5
        else innerFunction 15

    "Hello " + resultOfInner

let result = sayHello 9.6


//6.2 Mutablity

let mutable name = "isaac"
name <- "kate"


open System.Windows.Forms
let form = new Form()

form.Show()
form.Width <- 400
form.Height <- 400
form.Text <-  "Hello from F#"


open System.Windows.Forms
let form2 = new Form(Text = "Hello again from F#", Width = 300, Height = 300)
form2.Show()



let drive petrol distance = 
   if distance > 50 then petrol / 2.0
   elif distance > 25 then petrol - 10.0
   elif distance > 0 then petrol - 1.0
   else petrol

let petrol = 100.0
let firstState = drive petrol 60
let secondState = drive firstState 45
let finalState = drive secondState 0
let petrolUsed = finalState

petrolUsed


//7.2 Expressions

open System

let describeAge age = 
    let ageDescription = 
        if age < 18 then "Child"
        elif age < 65 then "Adult"
        else "OAP"

    let greeting = "Hello"
    Console.WriteLine("{0} you are {1}", greeting, ageDescription)

describeAge 48


//unit
let unKnown = ()




let writeTextToDisk text =
    let path = System.IO.Path.GetTempFileName()
    System.IO.File.WriteAllText(path, text)
    path

let createManyFiles = 
    ignore(writeTextToDisk "One line")
    ignore(writeTextToDisk "One line")
    writeTextToDisk "One line"

createManyFiles











