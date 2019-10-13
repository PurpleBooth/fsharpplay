namespace FizzBuzz

module FizzBuzz =
    let FizzBuzz name =
        if name % 15 = 0 then
            "fizzbuzz"
        elif name % 3 = 0 then
            "fizz"
        elif name % 5 = 0 then
            "buzz"
        else
            string name

    let OnList (inputs:int list): string list =
        List.map FizzBuzz inputs