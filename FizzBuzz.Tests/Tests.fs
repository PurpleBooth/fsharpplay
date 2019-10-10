module Tests

open System
open Xunit

[<Fact>]
let ``Check that by default the input number is converted into a string`` () =
    Assert.Equal("1", FizzBuzz.FizzBuzz.FizzBuzz(1))
