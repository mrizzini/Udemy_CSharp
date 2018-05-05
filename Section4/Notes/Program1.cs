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

        static void Main(string[] args)
        {

            // creating objects
            // need to allocate memory, so you use new keyword
            Person person = new Person();
            // or can use var keyword
            var person1 = new Person();

            // access members like name field
            person1.Name = "Mosh";
            person1.Introduce();

        }

        // creating a class
        // public is the access modifier (who can access), class is class keyword and person is the identified
        public class Person
        {
            // variables/fields
            public string Name;

            // method. void - does not return any values
            public void Introduce()
            {
                System.Console.WriteLine("Hi, my name is " + Name);
            }

        }


        // use static so that we can access the method Add directly by the calculator class itself. 
        // Calculator.Add(1, 2)
        // we don't need to create an object to access a static member
        // we can't actaully
        // we use this if we want it to be the only one
        // when you modify any members whether its a field or method with a static modifier that member will be accessible from the class itself not an object 
        public class Calculator
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
        }




    }
}