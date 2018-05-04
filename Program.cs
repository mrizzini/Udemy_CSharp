using System;
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
        }
    }
}
