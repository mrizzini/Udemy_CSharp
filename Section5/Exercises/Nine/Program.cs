// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

using System;

namespace Nine
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a series of numbers separated by a comma: ");
            var userNumbers = Console.ReadLine();
            var numbers = userNumbers.Split(',');
            // System.Console.WriteLine(numbers[0]);

            var max = Convert.ToInt32(numbers[0]);

            foreach (var number in numbers)
            {
                int test  = Convert.ToInt16(number);
                if (test > max)
                {
                    max = test;
                }
            }

            System.Console.WriteLine("Max number is {0}", max);

        }
    }
}
