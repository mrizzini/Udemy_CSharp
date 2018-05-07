// 2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Please enter your name: ");
            string nameString = Console.ReadLine();
            System.Console.WriteLine(nameString[0]);

            var nameArray = new char [nameString.Length];


            for (var i = 0; i < nameString.Length; i++)
            {
                nameArray[i] = nameString[i];
            }

            Array.Reverse(nameArray);
            string reversedName = string.Join("", nameArray);
            System.Console.WriteLine("Reversed name is {0}", 

        }
    }
}
