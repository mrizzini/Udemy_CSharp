// Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

using System;

namespace Seven
{
    class Program
    {

        static void Main(string[] args)
        {
            int factor = 1;
            System.Console.WriteLine("Please enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());            

            // var result = Math.factor(number);
            // System.Console.WriteLine(Math.factor(number));

            for (var i = 1; i <= number; i++)
            {
                factor *= i;
            }

            System.Console.WriteLine(factor); 
            

        }
    }
}
