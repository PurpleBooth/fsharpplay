namespace FizzBuzz

module FizzBuzz =
    let FizzBuzz name =
        if name % 3 = 0 then
            "fizz"
        elif name % 5 = 0 then
            "buzz"
        else
            "1"
