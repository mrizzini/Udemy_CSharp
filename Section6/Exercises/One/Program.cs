// 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
// If no one likes your post, it doesn't display anything.
// If only one person likes your post, it displays: [Friend's Name] likes your post.
// If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
// If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
// Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.



using System;
using System.Collections.Generic;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNameEntered = true;
            string name;
                        
            var nameList = new List<string>();

            // adds 1 to the end of the list?

            while (isNameEntered)
            {
                System.Console.WriteLine("Please enter a name or enter to exit: ");
                name = Console.ReadLine();

                if (name.Length < 1)
                {
                    break;
                }
                else
                {
                    // number += Convert.ToInt32(input);
                    nameList.Add(name);
                    // System.Console.WriteLine("name is: " + name);
                }
            }

            foreach(var n in nameList)
            {
                System.Console.WriteLine(n);
            }

            if (nameList.Count == 1)
            {
                System.Console.WriteLine(nameList[0] + " likes your post.");
            }
            else if (nameList.Count == 2)
            {
                System.Console.WriteLine(nameList[0] + " and " + nameList[1] + " like your post."); 
            }
            else if (nameList.Count >= 3)
            {
                System.Console.WriteLine(nameList[0] + ", " + nameList[1] + " and " + (nameList.Count - 2) + " others like your post."); 
            }


        }
    }
}
