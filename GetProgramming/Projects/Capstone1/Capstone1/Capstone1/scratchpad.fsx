open System


(*
1.  Your car starts with 100 units of petrol.
2.  The user can drive to one of four destinations. Each destination will consume a different amount of petrol:

    Home—25 units
    Office—50 units
    Stadium—25 units
    Gas station—10 units

5.  If the user tries to drive anywhere else, the system will reject the request.
6.  If the user tries to drive somewhere and doesn’t have enough petrol, the system will reject the request.
7.  When the user travels to the gas station, the amount of petrol in the car should increase by 50 units.
*)

// Couple of quick tests
//getDistance "Home" = 25
//getDistance "Stadium" = 50



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


let a = driveTo 100 "Office"
let b = driveTo a "Stadium"
let c = driveTo b "Gas"
let answer = driveTo c "Home"