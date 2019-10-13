namespace FizzBuzz

module FizzBuzz =
    let FizzBuzz input =
        if input % 15 = 0 then
            "fizzbuzz"
        elif input % 3 = 0 then
            "fizz"
        elif input % 5 = 0 then
            "buzz"
        else
            string input

    let OnList (inputs:int list): string list =
        List.map FizzBuzz inputs