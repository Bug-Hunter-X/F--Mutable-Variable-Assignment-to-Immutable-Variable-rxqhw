# F# Mutable Variable Assignment to Immutable Variable
This repository demonstrates a common error in F#: assigning a mutable variable to an immutable one.  The `bug.fs` file contains the erroneous code, while `bugSolution.fs` provides the corrected version.

**Problem:**
In F#, the type system strictly enforces immutability by default. Attempting to assign a mutable variable (declared with `mutable`) to an immutable variable will result in a compile-time error. The compiler will reject this assignment because it violates the immutability constraint.

**Solution:**
To fix this, either make the receiving variable mutable (using `mutable`) or use a different approach, such as creating a new immutable variable with the updated value.