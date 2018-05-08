// - Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

using System;
using System.Collections.Generic;


namespace Two
{
    class ProgramExercises7_2
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();
            
            if (String.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("Invalid, goodbye");
                return;
            }
            
            var inputArray = input.Split('-');            
            var numberList = new List<int>();

            foreach (var num in inputArray)
            {
                if (!numberList.Contains(Convert.ToInt32(num)))
                {
                    numberList.Add(Convert.ToInt32(num));
                }
                else
                {
                    System.Console.WriteLine("Duplicates");
                    return;
                }
            }

            System.Console.WriteLine("No duplicates");


        }
    }
}
