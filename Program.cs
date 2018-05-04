using System; // need this for Console.WriteLine
using System.Collections.Generic;
using System.Linq; // data
using System.Text; // text and coding
using System.Threading.Tasks; // build multi threaded apps


// we have access to any class in this namespace. if we want access to any other ones, we need to use "using" at the top
namespace Udemy_CSharp
{
    // 
    class Program
    {
        // entry point to our app, is Main. 
        // our default is string[] args.
        // void is our output. it will not return anything
        // blocks of code need to be surrounded by curly braces
        static void Main(string[] args)
        {
            // Console is a class which reads and writes data from the // Console. Various methods from console.
            // Console is defined in the System namespace
            Console.WriteLine("Hello World!");

            byte number = 2; // need to assign number before we use it
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A'; // store characters in single quotes
            string firstName = "Mosh"; // store strings in double quotes
            bool isWorking = false;
            Console.WriteLine(number); 
            Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);

            var numberOne = 1;
            // we can use var and the compiler will infer what we are using

            System.Console.WriteLine("{0} {1}", isWorking, numberOne);
            System.Console.WriteLine("{0} {1}", float.MaxValue, float.MinValue);

            const float Pi = 3.14f; // this value will not be changed in your program, so you don't accidently modify values


            // Implicit Type Conversion. 
            // Can do this when data loss will happen

            byte b = 1;

            int i = b;
            
            // OR

            int i = 1;

            float f = i;

            // CANT DO

            int i = 300;

            byte b = i;

            // Explicit Type Conversion
            // Casting

            int i = 1;

            byte b = (byte)i;

            // OR

            float = 1.0f;

            int i = (int)f;


            // Non-compatible

            string s = "1";

            int i = Convert.ToInt32(s);

            // OR

            // takes string and converts to the type needed
            int j = int.Parse(s) 



            // Demo

            byte b = 1;
            int i = b;
            System.Console.WriteLine(i);

            // WON'T WORK B/C DATA LOSS
            int i = 1;
            byte b = i;
            System.Console.WriteLine(i);

            // Need to explicity (aka cast)
            int i = 1;
            byte b = (byte) i;
            // the 1 is so small there will be no data loss here


            var numberString = "1234";
            // int i = (int) number; // cant do this
            int i = Convert.ToInt32(numberString);
            System.Console.WriteLine(i);


            // this will catch any exceptions
            try
            {
                var numberThree = "1234";
                byte b = Convert.ToByte(numberThree);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("The number could not be converted to a byte");
                throw;
            }


            // Postfix increment

            int a = 1;
            int b = a++;
            // first, the value of a is assigned to b and then a is incremented
            // a = 2
            // b = 1


            // Prefix increment

            int a = 1;
            int b = ++a;
            // first, a is incremented and then assigned to b
            // a = 2
            // b = 2


            // integer division - int / int == int

            var a = 1;
            var b = 2;
            System.Console.WriteLine(a != b); // returns true
            System.Console.WriteLine(!(a != b)); // returns false


        }
    }
}
