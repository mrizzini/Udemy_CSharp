using System;

namespace Notes
{
    class ProgramNotes
    {
        static void Main(string[] args)
        {
            // typeof DateTime is args structure in System

            var dateTime = new DateTime(2015, 1, 1);

            // current
            var now = DateTime.Now;

            //
            var today = DateTime.Today;

            System.Console.WriteLine("Hour: " + now.Hour);
            System.Console.WriteLine("Minute: " + now.Minute);

            // these are immutable, cannot be changed.
            // to change, use .Add

            // returns tomorow current time
            var tomorrow = now.AddDays(1);

            // go back in time use negative number
            var yesterday = now.AddDays(-1);

            // date time object has methods to convert to date or time string

            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.ToShortDateString());
            System.Console.WriteLine(now.ToLongTimeString());
            System.Console.WriteLine(now.ToShortTimeString());

            // to show date and time
            System.Console.WriteLine(now.ToString());

            // Concept of format specifiers
            // to string optionally takes an arugment, a format specifer
            System.Console.WriteLine(now.ToString("yyyy-MM-dd"));

            // can add time
            System.Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            

            // TIME SPANS
            // We have time span, which represents a length of time
            // can use to create one

            var timeSpan = new TimeSpan(1, 2, 3); // 1hr, 2min, 3sec

            // if we didnt have a value for min and sec we could do 
            var timeSpan2 = new TimeSpan(1, 0, 0);
            // OR
            var timeSpan3 = TimeSpan.FromHours(1);

            // if you have 2 date time objects and subtract them, you
            // get a time span

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            System.Console.WriteLine("Duration: " + duration);
            
            // Properties
            // each timespan has a number of properites that come in pairs
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);      
            // minutes property returns the minutes component in the time span object
            // so 2 in new TimeSpan(1, 2, 3)   
            // totalMinutes returns total of all them

            // Add
            // timespan is also immutable
            // can modify using add and subtract

            // add 8 minutes to original time span
            System.Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));   

            // Subtract
            System.Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));  

            // Conversion to and from strings

            // ToString method

            // Console.WriteLine auto does this, so you don't need this unless you are NOT using Console.WriteLine
            System.Console.WriteLine("ToString: " + timeSpan.ToString());;         

            // Parse
            System.Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
