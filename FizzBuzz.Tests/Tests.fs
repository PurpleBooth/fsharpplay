module Tests

open FsUnit
open System
open Xunit

[<Fact>]
let ``Check that by default the input number is converted into a string`` () =
    FizzBuzz.FizzBuzz.FizzBuzz(1) |> should equal "1" 

[<Fact>]
let ``Check that by default any number at all matches this`` () =
    FizzBuzz.FizzBuzz.FizzBuzz(2) |> should equal "2" 

[<Fact>]
let ``Instead of printing a number that is divisible by 3, print fizz instead`` () =
    FizzBuzz.FizzBuzz.FizzBuzz(3) |> should equal "fizz" 

[<Fact>]
let ``Instead of printing a number that is divisible by 5, print buzz instead`` () =
    FizzBuzz.FizzBuzz.FizzBuzz(5) |> should equal "buzz" 

[<Fact>]
let ``Instead of printing a number that is divisible by 15, print fizzbuzz instead`` () =
    FizzBuzz.FizzBuzz.FizzBuzz(15) |> should equal "fizzbuzz" 

[<Fact>]
let ``Check that behaviour is the same as the normal fizzbuzz behavior but for list items`` () =
    FizzBuzz.FizzBuzz.OnList([1; 2; 3; 5; 15]) |> should equal ["1"; "2"; "fizz"; "buzz"; "fizzbuzz"] 
