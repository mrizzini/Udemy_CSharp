// Write a program that reads a text file and displays the number of words.

// Write a program that reads a text file and displays the longest word in the file.

using System;
using System.IO;


namespace One
{
    class ProgramExercises9_1
    {
        static void Main(string[] args)
        {

            
            var path = @"/Users/matthewrizzini/Desktop/Visual Studio Projects/Udemy_CSharp/Section9/Notes/Program.cs";
            var fileText = File.ReadAllText(path);
            var test = fileText.Trim().Split(" ");
            System.Console.WriteLine(test.Length);

            string longestWord = test[0];
            var lengthCounter = 0; 
                       

            foreach (var word in test)
            {
                if (word.Length > lengthCounter)
                {
                    longestWord = word;
                    lengthCounter = word.Length;
                }
            }

            // for (var i = 1; i < test.Length - 1; i++)
            // {
            //     if (test[i].Length > test[i + 1].Length)
            //     {
            //         longestWord = test[i];
            //     }
            // }


            System.Console.WriteLine(longestWord);
            

        }
    }
}
