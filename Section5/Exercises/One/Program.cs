// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.

using System;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int input;
            System.Console.WriteLine("Please enter a number 1-10: ");
            input = Int32.Parse(System.Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                System.Console.WriteLine("Valid");
            }
            else 
            {
                System.Console.WriteLine("Invalid");
            }

        }
    }
}
