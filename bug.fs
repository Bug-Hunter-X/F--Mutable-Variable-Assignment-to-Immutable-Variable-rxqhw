let mutable x = 10
let y = &x
(*This will cause an error because you are trying to assign a mutable variable to an immutable one*) 
y := 20