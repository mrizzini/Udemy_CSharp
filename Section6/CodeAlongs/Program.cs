using System;
using System.Collections.Generic;

namespace CodeAlongs
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new [] {3, 7, 9, 2, 14, 6};

            // Length

            System.Console.WriteLine("Length is: " + numbers.Length);

            // IndexOf()
            // can return the index of a number you pass in
            var index = Array.IndexOf(numbers, 9);
            System.Console.WriteLine("Index is: " + index);

            // Clear()
            // array, starting index of range of index you want to clear, number of elements you want to clear
            // sets number to 0. array of booleans will set to false
            // strings will set to null
            Array.Clear(numbers, 0, 2);
            System.Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // Copy()
            // takes source array, the destination, the number of elements we want to copy. need to declare a new array to store it in
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            System.Console.WriteLine("Effect of Copy():");
            foreach (var n in another)
            {
                System.Console.WriteLine(n);
            }

            // Sort()
            // pass another array
            Array.Sort(numbers);
            System.Console.WriteLine("Effect of Sort():");
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);
            System.Console.WriteLine("Effect of Reverse():");
            foreach(var n in numbers)
            {
                System.Console.WriteLine(n);
            }


            // If a method is accessible on the class itself, like Array.Sort(), it is a static method. When a method or field or property is declared as static, it is accessible by class itself, otherwise it is accessible by the object


            // LISTS

            var numbersList = new List<int>();

             // OR to initialize
            
            var numbersList1 = new List<int>() {1, 2, 3, 4};

            // adds 1 to the end of the list?
            numbersList1.Add(1);

            // add range to add more than one object
            numbersList1.AddRange(new int[3] {5, 6, 7});

            foreach(var n in numbersList1)
            {
                System.Console.WriteLine(n);
            }


            // IndexOf()
            // returns index or -1 if not found
            // can add in range using different parameters
            System.Console.WriteLine("Index of 1 is: ");
            System.Console.WriteLine(numbersList1.IndexOf(1));

            // or can find the last index of a number
            System.Console.WriteLine("Last index of 1 is: ");
            System.Console.WriteLine(numbersList1.LastIndexOf(1));
            
            // returns number of objects in the list
            System.Console.WriteLine("Count: "+ numbersList1.Count);


            // Remove()
            // removes only the first instance
            numbersList1.Remove(1);
            System.Console.WriteLine("After removal: ");
            foreach(var n in numbersList1)
            {
                System.Console.WriteLine(n);
            }


            // you can use a for loop to remove multiple intances. CANT USE foreach
            for (var i = 0; i < numbersList1.Count; i++)
            {
                if (numbersList1[i] == 1)
                {
                    numbersList1.Remove(numbersList1[i]);
                }
            }


            foreach(var n in numbersList1)
            {
                System.Console.WriteLine(n);
            }

            // Clear()
            // removes all elements from list

            numbersList1.Clear();
            
            System.Console.WriteLine("After clear: ");
            System.Console.WriteLine("Count: "+ numbersList1.Count);
            
        }
    }
}
