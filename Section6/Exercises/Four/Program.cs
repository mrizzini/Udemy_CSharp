// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

using System;
using System.Collections.Generic;


namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            bool quit = false;
            var numbers = new List <int>();
            int number;
            

            while (!quit)
            {

                System.Console.WriteLine("Enter number or enter quit to exit");
                var input = Console.ReadLine();
                // var number = Convert.ToInt32(Console.ReadLine());
                if (input.ToLower() == "quit")
                {
                    quit = true;
                }
                else
                {
                    number = Convert.ToInt32(input);
                    numbers.Add(number);
                }

            }


            var numbersUnique = new List <int>();

            foreach(var n in numbers)
            {
                if (!numbersUnique.Contains(n))
                {
                    numbersUnique.Add(n);
                }
            }
            foreach(var n in numbersUnique)
            {
                    System.Console.WriteLine(n);
            }
        }
    }
}
