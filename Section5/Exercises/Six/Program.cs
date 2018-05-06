//  Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.


using System;

namespace Six
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumEntered = true;
            var number = 0;
            string input;
            

            while (isNumEntered)
            {
                System.Console.WriteLine("Please enter a number or ok to exit: ");
                input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }
                else
                {
                    number += Convert.ToInt32(input);
                    // number += input;
                }

            }

            System.Console.WriteLine(number);

        }
    }
}
