using System;

namespace Notes
{
    class ProgramNotes8
    {
        static void Main(string[] args)
        {
            // string keyword maps to the String class in the .NET framework
            // string is a class
            // string is immutable

            // ToLower() all to lower
            // ToUpper() all to upper
            // Trim() gets rid of whitespaces around strings
            // IndexOf('a') returns index of first occurance of a
            // LastIndexOf("Hello") returns index of last occurance
            // Substring(startIndex) creates substring of given string
            // Substring(startIndex, length) define length of new string
            // Replace('?', '!') // replace all ? with !
            // String.IsNullOrEmpty(str)
            // String.IsNullOrWhiteSpace(str)
            // str.Split(' ') split by empty space and return an array

            // string s = "1234"
            // int i = int.Parse(s) 
            // .Parse throws an exception if null or empty
            // OR
            // int j = Convert.ToInt32(s)
            // if string is null or empty, it returns 0

            // int i = 1234;
            // string s = i.ToString(); returns 1234
            // string t = i.ToString("C") returns $1,234.00
            // string t = i.ToString("C0") $1,234


            // STRING BUILDER

            // if you have a lot of string manipulation operations, you can use a string builder
            // System.Text
            // a mutable string
            // easy and fast to create and manipulate strings
            // NOT optimized for searching
            // Append()
            // Insert()
            // Remove()
            // Replace()
            // Clear()

        }
    }
}
