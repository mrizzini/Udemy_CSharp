// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

using System;
using System.Collections.Generic;


namespace One
{
    class ProgramExercises7_1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            // var answer = isConsecutive(input);
            System.Console.WriteLine(isConsecutive(input)); 
            // var numberList = new List<int>();
            
            // var inputArray = input.Split('-');
            // string msg = "Valid";

            // foreach (var num in inputArray)
            // {
            //     numberList.Add(Convert.ToInt32(num));
            // }

            // numberList.Sort();

            // for (var i = 1; i < numberList.Count; i++)
            // {
            //     if (numberList[i] != numberList[i - 1] + 1)
            //     {
            //         msg = "Invalid";
            //         break;
            //     }
            // }

            //     if (msg == "Invalid")
            //     {
            //         System.Console.WriteLine(msg);
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Valid");
            //     }

        }

        public static string isConsecutive(string input)
        {

            var numberList = new List<int>();
            
            var inputArray = input.Split('-');
            string msg = "";

            foreach (var num in inputArray)
            {
                numberList.Add(Convert.ToInt32(num));
            }

            numberList.Sort();

            for (var i = 1; i < numberList.Count; i++)
            {
                if (numberList[i] != numberList[i - 1] + 1)
                {
                    msg = "Invalid";
                    break;
                }
            }

                if (msg == "Invalid")
                {
                    // System.Console.WriteLine(msg);
                    return msg;
                }
                else
                {
                    // System.Console.WriteLine("Valid");
                    return "Valid";
                }

        }

    }
}
