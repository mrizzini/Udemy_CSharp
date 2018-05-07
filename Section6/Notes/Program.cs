using System;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array - fixed number of variables of a particular type
        
            // single dimension and multi demension

           var numbers = new int[5];

           // oR

           var numbers2 = new int[5] {1, 2, 3, 4, 5};


           // Multi demension

           // Rectangular - 5 rows 5 columns
           // Jagged - an array of arrays. each element is a single dimension array. if you want a matrix, maybe use this
           
           // To declare a two dimensional rectangular array:
            // 3 rows, 5 columns
           var matrix = new int[3, 5];
        
            // OR

            var matrix1 = new int[3, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15}
            };


            // jagged:

            var array = new int[3][];
            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];

            // ARRAYS HAVE PROPERTIES AND METHODS

            // Length, Clear(), Copy(), IndexOf(), Reverse(), Sort()



            // LISTS!

            // Arrays have fixed sizes, but lists are dynamic
            // Similar to array, it stores number of objects of the same type

            // List is a generic type, so we use the <>
            // inside <> specifies the type of list. can be strings, chars, or any non-primitives
            var listNumbers = new List<int>();

            // OR

            var listNumbers2 = new List<int>() {1, 2, 3, 4};

            // Methods:
            // Add() - add object to list
            // AddRange() - add list of objects that can be another list or array
            // Remove() - remove object from list
            // RemoveAt() - 
            // IndexOf() - 
            // Contains() - 
            // Count - number of objects in the list
        
        }
    }
}
