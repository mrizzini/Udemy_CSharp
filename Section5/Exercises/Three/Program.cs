// Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

using System;

namespace Three
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            System.Console.WriteLine("Please enter a height: ");
            height = Int32.Parse(System.Console.ReadLine());

            int width;
            System.Console.WriteLine("Please enter a width: ");
            width = Int32.Parse(System.Console.ReadLine());

            if (width > height)
            {
                System.Console.WriteLine("You have a landscape");
            }
            else if (height > width)
            {
                System.Console.WriteLine("You have a portrait");
            }
            else
            {
                System.Console.WriteLine("They are even");
            }


        }
    }
}
