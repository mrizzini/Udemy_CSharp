using System;

namespace CodeAlongs
{
    class Program
    {
        static void Main(string[] args)
        {


            // CONDITIONALS

            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                    System.Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("It's afternoon");
            } 
            else
            {
                System.Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = true;

            // float price;
            // if (isGoldCustomer)
            // {
            //     price = 19.95f;
            // }
            // else
            // {
            //     price = 29.95f;
            // }

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            // same as the if/else abov. if isGoldCustomer true, price is equal to 19.95. Else, price is 29.95

            System.Console.WriteLine(price);


            var season = Season.Winter;

            switch (season)
            {
                case Season.Autumn:
                    System.Console.WriteLine("It is autumn");
                    break;

                case Season.Summer:
                case Season.Winter:
                    System.Console.WriteLine("We have summer and winter promos");
                    break;
                    
                default:
                    System.Console.WriteLine("I don't understand");
                    break;

            }



            // LOOPS

            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }


            var nameLoop = "John Smith";

            // for (var i = 0; i < nameLoop.Length; i++)
            // {
            //     System.Console.WriteLine(nameLoop[i]);
            // }

            // OR

            // character will hold one character in the string
            // good to use in strings and lists and arrays
            foreach (var character in nameLoop)
            {
                System.Console.WriteLine(character);
            }


            var numbers = new int[] {1, 2, 3, 4};

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            System.Console.WriteLine("Time for while loops");

            // use while loops if you do not know ahead of time how many times you are going to iterate
            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    System.Console.WriteLine(j);
                }
                j++;
            }


            // while (true)
            // {
            //     System.Console.Write("Type your name: ");
            //     var input = Console.ReadLine();

            //     // if user doesnt enter a name and hits enter, we 

            //     // if input is null or whitespace
            //     // if (String.IsNullOrWhiteSpace(input));
            //     // {
            //     //     break;
            //     // }

            //     // System.Console.WriteLine("@Echo: " + input);
                

            //     if (!String.IsNullOrWhiteSpace(input));
            //     {
            //         System.Console.WriteLine("@Echo: " + input);
            //         continue;
            //     }

            //         break;

            // }

            // RANDOM CLASS

            // can create random numbers, etc
            var random = new Random();
            const int passwordLength = 10;            
            char [] buffer = new char[passwordLength];

            for (var k = 0; k < passwordLength; k++)
            {
                // random.Next() can take min and max
                // System.Console.WriteLine(random.Next()); 
                // System.Console.WriteLine(random.Next(1, 10));
                
                // we can represent random letters too
                // System.Console.Write((char)random.Next(97, 122));

                // OR

                // System.Console.Write((char)('a' + random.Next(0, 26)));

                // OR CAN STORE IN ARRAY

                buffer[k] = (char)('a' + random.Next(0, 26));

                // gives us a string based on the character array
                
                

            }

            var password = new string(buffer);
            System.Console.WriteLine();
            System.Console.WriteLine(password);
            


        }
    }
}
