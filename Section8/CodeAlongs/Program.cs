using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAlongs
{
    class ProgramCodeAlongs8
    {
        static void Main(string[] args)
        {

            // NONE OF THESE CHANGE ORIGINAL STRING!!!

             var fullName = "Mosh Hamedani  "; // has whitespace at end

             // Trim()
             System.Console.WriteLine("Trim: '{0}'", fullName.Trim());
             // helpful when compparing strings

            // ToUpper
             System.Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

             // Substring
             var index = fullName.IndexOf(' ');
             // based on this index, we want to split string
             var firstName = fullName.Substring(0, index);
             var lastName = fullName.Substring(index + 1);
             System.Console.WriteLine("FirstName: " + firstName);
             System.Console.WriteLine("LastName: " + lastName);

             // OR USE
             // Split()

             var names = fullName.Split(' ');
             System.Console.WriteLine("FirstName: " + names[0]);
             System.Console.WriteLine("LastName: " + names[1]);

             // Replace()

             var replace = fullName.Replace("Mosh", "Moshfegh");
             System.Console.WriteLine("Replace: " + replace);

            // IsNullOrEmpty()
            // You want to check if user did input something

            // if (String.IsNullOrEmpty(null))
            // OR
            if (String.IsNullOrEmpty(""))
            
            {
                System.Console.WriteLine("Invalid");
            }

            // to check if user has put in empty string

            if (String.IsNullOrWhiteSpace(" "))
            
            {
                System.Console.WriteLine("Invalid");
            }

            // Conversion
            // inputs come as a string

            // Convert.ToInt()
            var str = "25";
            var age = Convert.ToInt32(str);
            // if we know value is small we can do:
            var ageByte = Convert.ToByte(str);

            // ToString()

            float price = 29.95f;
            // use format string to put to currency
            var currency = price.ToString("C0"); // no decimals. if you want decimals, use just C
            System.Console.WriteLine(currency);


            // Summarizing Text
            var sentence = "This is going to be a really really really really really really really really long text";
            var summary = StringUtility.SummarizeText(sentence, 23);
            System.Console.WriteLine(summary);


            // String Builder

            var builder = new StringBuilder();

            // this will append the - 10 times
            builder.Append('-', 10);
            builder.AppendLine();     
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);                    
            System.Console.WriteLine(builder);

            builder.Replace('-', '+');
            System.Console.WriteLine(builder);

            builder.Remove(0, 10);
            System.Console.WriteLine(builder);
            
            // add in 10 - at the beginning 0
            builder.Insert(0, new String('-', 10));
            System.Console.WriteLine(builder);
            
            // string builder doesnt create a new string so if you have a lot, we can save on memory and cost using this

            // use index to access individual characters
            System.Console.WriteLine("First character: " + builder[0]);

            // we can chain the append and replce methods, because they all return a string builder

            // builder
            //     .Append('-', 10)
            //     .AppendLine()   
            //     .Append("Header")
            //     .AppendLine()
            //     .Append('-', 10);                  
            // System.Console.WriteLine(builder);

             
        }

        // we want our summarize to be a reusable method
        // need to make a method, a static one
        // make a method in StringUtility.cs
 
    }
}
