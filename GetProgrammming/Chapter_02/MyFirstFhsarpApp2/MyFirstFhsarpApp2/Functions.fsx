

//Functions

//curried functions

let add first second = first + second
let addFive = add 5
let fifteen = addFive 10

fifteen


//Constraining functions
open System
let buildDt year month day = DateTime(year, month, day)
let buildDtThisYear month day = buildDt DateTime.UtcNow.Year month day
let buildDtThisMonth day = buildDtThisYear DateTime.UtcNow.Month day

//No explicit parameters
let obuildDtThisYear = buildDt DateTime.UtcNow.Year
let obuildDtThisMonth = obuildDtThisYear DateTime.UtcNow.Month


//Write to File Function
open System
open System.IO

let writeToFile (date:DateTime) filename text =
    let path = sprintf @"C:\Users\ihashmi\Source\github\fsharpBook\GetProgrammming\Chapter_02\MyFirstFhsarpApp2\MyFirstFhsarpApp2\Files\%s-%s.txt" (date.ToString "yyMMdd") filename
    File.WriteAllText(path, text)

let writeToToday = writeToFile DateTime.UtcNow.Date
let writeToTomorrow = writeToFile (DateTime.UtcNow.Date.AddDays 1.0)
let writeToTodayHelloWorld = writeToToday "hello-world"
writeToToday "first-file" "the quick brown fox jumped over the lazy dog"
writeToTomorrow "second-file" "the even quicker brown fox jumped over the lazy dog."
writeToTodayHelloWorld "the quicker brown fox jumped even higher over the lazy dog"

//Write to File Function
open System
open System.IO

//works
let writeToFile2  directoryName fileName text =

    let path = @"C:\Users\ihashmi\Source\github\fsharpBook\GetProgrammming\Projects\Capstone2\output\"

    let directory = sprintf "%s\%s" path directoryName

    let directoryExists = Directory.Exists(directory) 

    if not directoryExists
        then Directory.CreateDirectory(directory) |> ignore
    
    let fullPath = sprintf "%s\%s\%s.txt" path directoryName fileName
    
    let textOut = text + Environment.NewLine
    
    File.AppendAllText(fullPath, textOut)

   
let output = writeToFile2 "Alberta" "test2" "hello2"
output



//Pipelines
let time = 
    let directory = Directory.GetCurrentDirectory()
    Directory.GetCreationTime directory

let directoryName = Directory.GetCurrentDirectory()


//from lesson 6

let drive distance petrol =                                          //notice parameters reversed to suit pipeline                        
    if distance = "far" then petrol / 2.0
    elif distance = "medium" then petrol - 10.0
    else petrol - 1.0

(*
let petrol = 100.0                                       
let firstState = drive "far" petrol                    
let secondState = drive "medium" firstState
let finalState = drive "short" secondState
finalState
*)

let startingPetrol = 100.0

startingPetrol
|> drive "far"
|> drive "medium"
|> drive "short"





let addTwoNumbers firstNumber secondNumber = 
    firstNumber + secondNumber


addTwoNumbers 40 15






























 

    