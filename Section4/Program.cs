using System;
using Section4.Math;

namespace Section4
{

    // if we don't set values, first will be 0 then it will be incremented so you should set them at first
    // we can use this in main method now
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create an object
            // Person john = new Person();
            // OR
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
            

            var calculator = new Calculator();
            var result = calculator.Add(5, 2);
            System.Console.WriteLine("hey " +  result);


            int[] numbers = new int[3];
            // OR

            var numbers2 = new int[3];
            numbers2[0] = 1;
            // numbers[1] = 2;
            // numbers[2] = 3;
            // when you declare an array, all the elements are set to the default value of that data type for the array. with an int, it is 0

            System.Console.WriteLine(numbers2[0]);
            System.Console.WriteLine(numbers2[1]);
            System.Console.WriteLine(numbers2[2]);

            var flags = new bool[3];
            flags[0] = true;
            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);

            // can use the object initialization syntax, as below

            var names = new string[3] {"Jack", "John", "Mary"};
            System.Console.WriteLine(names[0]);



            var firstName = "Mosh";
            var lastName = "Hamedani";
             // all primitive types map to a type in the .NET Framework
             // we have a class in the System namespace called String
             // can use string or String to declare it      

             var fullName = firstName + " " + lastName;
             System.Console.WriteLine(fullName);     

             var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

             System.Console.WriteLine(myFullName);
            
            var allNames = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(", ", allNames);
            System.Console.WriteLine(formattedNames);


            var text = @"Hi John 
            Look into the following paths
            c:\folder";
            System.Console.WriteLine(text);


            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method);

            // imagine we recieve the following from somewhere else, we can cast it as a shipping method

            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId);
            // this casts this 3 as Express

            // we can convert method to a string. every object has toString method
            // Console.WriteLine auto converts to string

            System.Console.WriteLine(method.ToString());


            var methodName = "Express";
            // we will parse this. take string and convert to different type. we want to parse this to a shipping method
            // .NET gives us acccess to Enum.
            // .Parse takes type of what you want to convert
            var ShippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            // turns variable into shipping method. converts a string into an enum


            // VALUE TYPES

            var a = 10;
            var b = a;
            b++;
            // ints are value types
            // When we copy a value type to another variable, a copy of that value is taken and stored in the target location/variable in memory.
            // their value is COPIED
            System.Console.WriteLine(string.Format("a is {0} b is {1}", a, b));


            // REFERENCE TYPES

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            // first element of array 1 will be 0
            // arrays are passed by reference
            // so you can assign array2 to array1 but you will still be changing array1 if you modify array2
            // array1 and array2 are created on the stack but
            // they both point to the memory address on the heap
            System.Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

        }
    }

    public class Person
    {
        // declare some fields
        public string FirstName;
        public string LastName;
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }


        // public class Calculator
        // {
        //     public int Add(int a, int b)
        //     {
        //         return a + b;
        //     }
        // }


}
