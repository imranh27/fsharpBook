module Car

open System

//TODO: Create helper functions to provide the building blocks to implement driveTo.

///Returns Distance for each desitnation
let getDistance destination =
    if destination = "Gas" then 10
    elif destination = "Home" then 25
    elif destination = "Stadium" then 25
    elif destination = "Office" then 50
    else failwith "Unknown Desination!"

/// Returns the Remaining Petrol for a distance
let calculateRemainingPetrol currentPetrol distance =
    if currentPetrol >= distance then currentPetrol - distance
    else failwith "Oops you have run out of Petrol!"

/// Figures out remainder petrol
let driveTo petrol destination = 

    let gasUplift = 
        if destination = "Gas" then petrol + 50
        else petrol

    let distance = getDistance destination
    let canIgetthere = calculateRemainingPetrol gasUplift distance
    
    canIgetthere

