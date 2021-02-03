using System;
using System.Collections.Generic;
/*Write a program and ask the user to enter a few numbers separated by a hyphen.
 * If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
 * If so, display "Duplicate" on the console.
 */

namespace Beginner_Exercises.Working_With_Text
{
    class DuplicateNumber
    {
        public static void Run()
        {
            Console.WriteLine("enter a few numbers separated by a hyphen'-' e.g. '5 - 6 - 7 - 8 - 9':");
            var input = Console.ReadLine();
            var elements = input.Split('-');

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input");
                return;
            }
            else
            {
                var numbers = new List<int>();
                foreach(var element in elements)
                {
                    if (numbers.Contains(Convert.ToInt32(element)))
                    {
                        Console.WriteLine("Duplicate number found.");
                        break;
                    }else
                        numbers.Add(Convert.ToInt32(element));

                }
                    
            }




        }
    }
}
