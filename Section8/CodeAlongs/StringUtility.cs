using System;
using System.Collections.Generic;

namespace CodeAlongs
{
    public class StringUtility
    {

        public static string SummarizeText(string text, int maxLength = 20)
        {
            // const int maxLength = 20;

            // check if length is greater than what we want. if so, then we summarize it

            if (text.Length < maxLength)
            {
                // System.Console.WriteLine(text);
                return text;
            }
            else
            {
                // text.Substring(0, maxLength);
                // dont want to do this way
                // we want to take into account the word boundries.
                // count number of words that fit into 20 characters
                // first break sentence into words
                // lets get a string array, words
                var words = text.Split(' ');
                var totalCharacters = 0;
                // need a place to store summary words. use a list
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    // + 1 TO ACCOUNT FOR SPACE AFTER WORD
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                    summaryWords.Add(word);
                    
                }

                // summaryWords has what we want. need to join these words into a string
                // var summary = String.Join(" ", summaryWords); //+ "...";
                // System.Console.WriteLine(summary + "...");
                return String.Join(" ", summaryWords) + "...";

            }
        }
    }
}



