// string is a sequence of characters.
// use double quotes

// string literal:

string firstName = "Moshy";
string lastName = "Beazley";
// concatenate

string name = firstName + " " + lastName;

// string format
// placeholders are replaced by whatever comes after the comma

string nameFormat = string.Format("{0} {1}", firstName, lastName);

// string join

// this will join the numbers array, separated by a comma
var numbers = new int[3] {1, 2, 3};
string list = string.Join(",", numbers);


// you can access chars in a string by index
// strings are immutable, cannot be changed with name[0] = 'm'
// we have methods that we can use which return a new string but the
// original string is not changed


\n - new line

\t - tab

\\ - backslash

\' single quote

\" - double quote


// verbatim strings so we don't have to use escape characters, use @

string path = @"c:\projects\project1\folder1";
