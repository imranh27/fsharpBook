


//Lesson 9

//tuples
let parseName(name:string) = 
    let parts = name.Split(' ')
    let forename = parts.[0]
    let surname = parts.[1]
    forename, surname

let name = parseName "Isaac Abraham"
let forename, surname = name
let forname, surnam = parseName "Peter Pan"




/// Tuple for Player Game Score
let parseGame(nameGameScore:string) = 
    let parts = nameGameScore.Split(' ')
    let playerName = parts.[0]
    let game = parts.[1]
    let score = parts.[2]
    playerName, game, int(score)

let a, b, c = parseGame("Player1 Asteroids 1988")


let nameAndAge = ("Joe", "Bloggs"), 28          
let name, age = nameAndAge                      
let (forename, surname), theAge = nameAndAge    


//discarding elements
let nameAndAge = "Jane", "Smith", 25
let forname, surname, _ = nameAndAge


//type inference

let explicit : int * int = 10, 5
let implicit = 10, 5

let addNumbers arguments = 
    let a, b = arguments
    a + b

addNumbers implicit




