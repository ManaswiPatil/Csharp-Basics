using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
 * So, if the user enters "inadequate", the program should display 6 on the console.
 */
namespace Beginner_Exercises.Working_With_Text
{
    class CountVowels
    {
        public static void Run()
        {
            Console.WriteLine("Enter an English Word:");
            var input = Console.ReadLine();
            var word = input.ToLower();

            var count = 0;
            foreach(var letter in word)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine("Number of Vowels:"+ count);
        }
    }
}
