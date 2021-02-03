using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Exercises.Working_With_Text
{
    class SummarisingText
    {
        public static void Run()
        {
            var sentence = "Any fool can write code that a computer can understand. Good programmers write code that humans can understand.";
            var summary = SummerizeText(sentence);
            Console.WriteLine(summary);
        }

        static string SummerizeText(string Text)
        {
            const int maxLength = 20;

            if (Text.Length < maxLength)
                return Text;
            else
            {
                var words = Text.Split(' ');    //string array 'words' for words in the sentence.
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                var summary = String.Join(" ", summaryWords) + "...";
                return summary;
            }

        }
    }
}
