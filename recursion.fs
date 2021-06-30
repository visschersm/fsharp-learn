let rec length =
    function
    | [] -> 0
    | x :: xs -> 1 + length xs

let rec factorial n =
    if n < 2 then
        1
    else
        n * factorial (n - 1)

let rec recursion n =
    if n > 3 then
        3
    else
        printfn "%i" n
        recursion <| n + 1

7. |> sin |> ((*) 2.)

let (^) x y = x ** y

[ 1; 2; 3; 4 ]
|> List.filter (fun i -> i % 2 = 0)
|> List.map ((*) 2)
|> List.sum

let minus1 x = x - 1
let times2 = (*) 2
times2 << minus1 <| 9


let mul (x: int) (y: int) = x * y
let add (x: int) (y: int) = x + y
let pythagoras (x: int) (y: int) = add (mul x x) (mul y y)

let add x y = x + y
let mul x y = x * y

let foo = add 1 2
    |> add 3

let rec foo n = 
    if n <= 0 
    then 0
    else n + foo (n - 1)

let rec factorial n = 
    if n <= 0 
    then 1
    else n * factorial (n - 1)

// 1 1 2 3 5 8
let rec fibonacci n =
    if n <= 0 then 0
    elif n = 1 then 1
    else fibonacci (n - 1) + fibonacci (n - 2)

let fibonacciList n =
    for i in 0 .. n do
        printfn "%i" (fibonacci i)