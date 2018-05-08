// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 

using System;
using System.Collections.Generic;


namespace Three
{
    class ProgramExercises7_3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time in 24hr format: ");
            string input = Console.ReadLine();
            var numStr = input.Replace(":", "");
            System.Console.WriteLine(numStr);
            var number = Convert.ToInt32(numStr);


            if (number < 0 || number > 2359 || String.IsNullOrWhiteSpace(input) )
            {
                System.Console.WriteLine("Invalid");
            }
            else
            {
                System.Console.WriteLine("Ok");
            }

            // Replace('?', '!') // replace all ? with !
            
            // var time = input.ToString("yyyy-MM-dd HH:mm")

            // System.Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            
            // var curr = DateTime.Now;
            // Console.WriteLine(input.ToString("HH:mm"));
            // string s = ???;
            // Console.WriteLine(s);
        }
    }
}
