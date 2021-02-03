using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Exercises.Working_with_Files
{
    class ReadFile
    {
        public static void Run()
        {
            var path = @"D:\Data Science\ASP.NET\Exercises\Beginner Exercises\Working with Files\Sample.txt";
            // File.Create(path);

            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            Console.WriteLine();
            var words = text.Split(' ');
            var count = words.Length;
            Console.WriteLine("Number of words in the file:" + count);

            var max = 0;
            var longestWord = "";
            foreach(var word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    longestWord = word;
                }

            }

            Console.WriteLine("Longest Word in the file is:" + longestWord);
        }
    }
}
