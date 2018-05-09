// 2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

// PROCEDURAL PROGRAMMING

using System;

namespace Two
{
    class ProceduralProgramming
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Please enter your name: ");
            string nameString = Console.ReadLine();
            var reversed = ReversedName(nameString);
            System.Console.WriteLine("Reversed name is {0}", reversed);

            // var nameArray = new char [nameString.Length];

            // for (var i = 0; i < nameString.Length; i++)
            // {
            //     nameArray[i] = nameString[i];
            // }

            // Array.Reverse(nameArray);
            // string reversedName = string.Join("", nameArray);

        }

    // in order to call this from main we need static here
    // should return a string to return type string
    // need to take in nameString var
    public static string ReversedName(string nameString)
    {

        var nameArray = new char [nameString.Length];

        for (var i = 0; i < nameString.Length; i++)
        {
            nameArray[i] = nameString[i];
        }

        Array.Reverse(nameArray);
        // string reversedName = string.Join("", nameArray);

        // return reversedName;

        return string.Join("", nameArray);
        

    }

    }
}
