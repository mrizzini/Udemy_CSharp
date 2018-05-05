//  Write a program which takes two numbers from the console and displays the maximum of the two.

using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            System.Console.WriteLine("Please enter a number: ");
            input = Int32.Parse(System.Console.ReadLine());

            int inputTwo;
            System.Console.WriteLine("Please enter another number: ");
            inputTwo = Int32.Parse(System.Console.ReadLine());

            if (input > inputTwo)
            {
                System.Console.WriteLine("Max is " +  input);
            }
            else
            {
                System.Console.WriteLine("Max is " + inputTwo);
            }

        }
    }
}
