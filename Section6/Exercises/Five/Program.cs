// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

using System;
using System.Collections.Generic;

namespace Five
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10): ");
            string nums = Console.ReadLine();
            string[] numArray = nums.Split(",");
            var numbers = new List <int>();
            


            foreach(var n in numArray)
            {
                numbers.Add(Convert.ToInt32(n));
            }

            if (numbers.Count < 5 || numbers.Count < 1)
            {
                Console.WriteLine("Invalid, retry");
                return;
            }
            else
            {
                numbers.Sort();
            }


            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // foreach(var n in numbers)
            // {
            //         System.Console.WriteLine(n);
            // }

        }
    }
}
