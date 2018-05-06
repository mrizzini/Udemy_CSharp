// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

using System;

namespace Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var random = new Random();
            var randomNum = random.Next(1, 10);
            var guesses = 4;
            System.Console.WriteLine(randomNum);
            int userGuess;

            while (guesses > 0)
            {
                System.Console.WriteLine("Guess a number between 1 and 10: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == randomNum)
                {
                    System.Console.WriteLine("You won!");
                    break;
                }
                guesses--;
            }
            
            if (guesses == 0)
            {
                System.Console.WriteLine("You lose!");
            }

        }
    }
}
