int

char

float

bool

classes

structures

arrays (System.Array)

strings (System.String)

// We can create new types with Structures or Classes. 

// All primitive types are structures, as well as Custom Structures

// Arrays, Strings, Custom classes are all classes


// Structures are value types

    // when you create a variable of value type, memory is allocated on the stack. 
    // Done automatically
    // Immediately removed when out of scope


// Classes are reference types

    // you need to allocate memory yourself when you use reference
    // useing new keyword
    // memory allocated on the heap
    // won't be removed immmediately out of scope
    // Garbage collected by CLR every once in awhile


// var anotherObject = someObject