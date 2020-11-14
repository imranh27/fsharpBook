
namespace Capstone2.Domain

//Customer
type Customer = 
    { CustomerID : System.Guid
      CustomerName : string}


//Bank account
type Account = 
    { Customer : Customer
      AccountID : System.Guid
      Deposit : decimal
      Withdrawal : decimal
      Balance : decimal}

