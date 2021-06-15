let foo = [
    for r in 1..8 do 
    for c in 1..8 do
        yield (r, c)
]

let bah = [for x in 1..10 -> x * 2]

let tuple = ("Bob", 55)
let (name, age) = tuple

type Person = {
    name: string;
    age: int
}

let person = { name = "Bob"; age = 55 }
let name = person.name
let age = person.age

let olderPerson = { person with age = 56 }