using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCodes.String
{
    class StringSummary
    {
        static void MainStringSummary(string[] args) //Main
        {
            var sentence = "This is going to be a really really really long sentence";
            var summary = SummerizeText(sentence);
            Console.WriteLine(summary);
        }

        static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;
            else
            {
                var words = text.Split(' ');
                var totalChar = 0;
                var summary = new List<string>();
                foreach (var word in words)
                {
                    summary.Add(word);
                    totalChar += word.Length + 1; //Because of the space after the words
                    if (totalChar > maxLength)
                        break;
                }

                return string.Join(" ", summary) + "...";
            }
        }

    }
}
