// Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

using System;
using System.Collections.Generic;


namespace Five
{
    class ProgramExercises7_5
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an English word: ");
            var input = Console.ReadLine();
            var vowels = 0;

            if (String.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("Invalid, goodbye");
                return;
            }

            // var trimmed = input.Trim();    

            // System.Console.WriteLine(trimmed + " is " + trimmed.Length + " long");        

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e'|| input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    vowels++;
                }
            }

            System.Console.WriteLine("Vowels: {0}", vowels);



        }
    }
}
