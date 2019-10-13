module Tests

open System
open Xunit

[<Fact>]
let ``Check that by default the input number is converted into a string`` () =
    Assert.Equal("1", FizzBuzz.FizzBuzz.FizzBuzz(1))

[<Fact>]
let ``Instead of printing a number that is divisible by 3, print fizz instead`` () =
    Assert.Equal("fizz", FizzBuzz.FizzBuzz.FizzBuzz(3))

[<Fact>]
let ``Instead of printing a number that is divisible by 5, print buzz instead`` () =
    Assert.Equal("buzz", FizzBuzz.FizzBuzz.FizzBuzz(5))
