// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

using System;
using System.Collections.Generic;


namespace Three
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List <int>();
            int temp;
            

            while (numbers.Count < 5)
            {

                System.Console.WriteLine("Enter a number: ");
                temp = Convert.ToInt32(Console.ReadLine());

                if (!numbers.Contains(temp))
                {
                    numbers.Add(temp);
                }
                else
                {
                    System.Console.WriteLine("You already enterted that number");
                }
                // for (var i = 0; i < numbers.Length; i++)
                // {
                //     if (temp == numbers[i])
                //     {
                //         System.Console.WriteLine("Make sure number is unique. Try again");
                //         break;
                //     }
                // }
            }

            numbers.Sort();

            foreach(var n in numbers)
            {
                System.Console.Write(n);
            }

            System.Console.WriteLine();

        }
    }
}
