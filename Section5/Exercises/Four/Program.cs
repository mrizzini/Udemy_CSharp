// - Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

using System;

namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            System.Console.WriteLine("Please enter a speed limit ");
            speedLimit = Int32.Parse(System.Console.ReadLine());

            int carSpeed;
            System.Console.WriteLine("Please enter a car speed: ");
            carSpeed = Int32.Parse(System.Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                System.Console.WriteLine("Ok");
            }
            if (carSpeed > speedLimit)
            {
                int difference = carSpeed - speedLimit;
                int demerit = difference / 5;
            
                if (demerit > 12)
                {
                    System.Console.WriteLine("Over 12 demerits, License Suspended");
                }
                else
                {
                    System.Console.WriteLine(String.Format("You have {0} demerits.", demerit));
                }
            }

        }
    }
}
