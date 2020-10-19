


//Records

//create
type Address = 
    { Street: string 
      Town: string 
      City: string }


type Customer = 
     { Forename: string
       Surname: string
       Age: int
       Address : Address
       EmailAddress: string }

//use
let customer = 
    { Forename = "Joe"
      Surname = "Blogs"
      Age = 39
      Address = 
          { Street = "The Street"
            Town = "The Town"
            City = "The City"}
      EmailAddress = "joe@theemail.com"}



type Car = 
    { Make: string 
      Model: string 
      CarAge: int 
      Mileage: int
      Doors: int}

let golf : Car = 
    { Make = "VW"
      Model = "Golf"
      CarAge = 4
      Mileage = 4000
      Doors = 4}

let zx = 
    { Make = "Citroen"
      Model = "ZX"
      CarAge = 6
      Mileage = 80000
      Doors = 5}


//Updating a Record

let updatedCustomer = 
    { customer with 
        Age = 31
        EmailAddress = "Joe@bloggs.co..uk"}


type FullAddress = 
    { Line1: string
      County: string
      PostCode: string}

let myAddress1 = 
    { Line1 = "39 Kyme Street"
      County = "North Yorkshire"
      PostCode = "YO1 6HG"}

let myAddress2 = 
    { Line1 = "39 Kyme Street"
      County = "North Yorkshire"
      PostCode = "YO1 6HG"}

myAddress1 = myAddress2
myAddress2.Equals(myAddress2)
System.Object.Equals(myAddress1, myAddress2)




//new
let joeBloggs = 
    { Forename = "Joe"
      Surname = "Blogs"
      Age = 39
      Address = 
          { Street = "The Street"
            Town = "The Town"
            City = "The City"}
      EmailAddress = "joe@theemail.com"}

joeBloggs.Age


///Function to create random number between two numbers of choice.
//Define
let generateRandomNumber floor ceiling = 
    let r = System.Random()
    let nextValue = r.Next(floor, ceiling)
    nextValue

//Execute
let newAge = generateRandomNumber 18 45

let updateCustomerAge customer:Customer =
    let funnyAgeCustomer = 
         {customer with 
              Age = newAge}
    funnyAgeCustomer
    
let updatedJoeBlogs = updateCustomerAge joeBloggs

joeBloggs.Age

updatedJoeBlogs.Age









