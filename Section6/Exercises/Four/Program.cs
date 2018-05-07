// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

using System;

namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            bool quit = false;

            while (!quit)
            {

                System.Console.WriteLine("Enter number or enter quit to exit");
                var input = Console.ReadLine();
                var number = Convert.ToInt32(Console.ReadLine());
                if ("quit" == input.ToLower())
                {
                    quit = true;
                }
                else
                {
                    
                }

            }
        }
    }
}
