// Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

using System;
using System.Collections.Generic;


namespace Four
{
    class ProgramExercises7_4
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a few words separated by a space: ");
            var input = Console.ReadLine();
            
            if (String.IsNullOrWhiteSpace(input))
            {
                System.Console.WriteLine("Invalid, goodbye");
                return;
            }
            
            var inputArray = input.Split(" ");            
            var stringList = new List<string>();
            // var finalList = new List<string>();

            // foreach(var word in inputArray)
            // {
            //     string lowerCase = word.ToLower();
            //     stringList.Add(lowerCase);                
            // }

            foreach (var word in inputArray)
            {
                // stringList.Add((word));
                string wordPascal = Char.ToUpper(word[0]) + word.ToLower().Substring(1);
                stringList.Add(wordPascal);
            }

            foreach (var word in stringList)
            {
                System.Console.Write(word);
            }

            System.Console.WriteLine();

        }
    }
}
