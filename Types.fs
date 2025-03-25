module Types

let g = -9.8

let add (a: int) (b: int) : int = a + b

// int -> (int -> int)
let add3 = add 3
let add5 = add 5

let myList = [ 1; 2; 3; 4 ] |> List.map (fun x -> x * 2) |> List.sum

type MyService = { blah: int; hey: string }

let getAllUsers (repository: MyService) (accountId: int) : int list = [ 1; 2; 3 ]

let computation =
    let myService = { blah = 0; hey = "test" }

    let blah: (int * int) = 3, 4

    let x = 123 |> getAllUsers myService |> List.map (fun y -> y * 2) |> List.sum
    0

type Maybe<'a> =
    | Nothing
    | Just of 'a

type Either<'b, 'a> =
    | Left of 'b
    | Right of 'a

type AccountNumber = AccountNumber of string
type CreditCardNumber = CreditCardNumber of string
type ExpiryDate = ExpiryDate of string
type Cvv = Cvv of string

type Payment =
    | Cash
    | Cheque
    | BankTransfer of AccountNumber
    | CreditCard of (CreditCardNumber * ExpiryDate * Cvv)

let creditcard = CreditCard(CreditCardNumber "credit", ExpiryDate "exp", Cvv "cvv")

let processPayment amount payment =
    match payment with
    | Cash -> 0
    | Cheque -> 0
    | BankTransfer(AccountNumber "1223") -> 0
    | BankTransfer _ -> 0
    | CreditCard(cardNum, exp, cvv) -> 0

let rec myMap fn =
    function
    | [] -> []
    | x :: rest -> fn x :: myMap fn rest

// Next time: syntax (indentation, comments, etc)
// common data types (Option, Result, Task, Async)
// Computation Expressions, Type Providers and SAFE Stack (Wordle)
