using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to continuously enter a number or type "Quit" to exit.
 * The list of numbers may include duplicates. Display the unique numbers that the user has entered.
 */

namespace Beginner_Exercises.Arrays_and_Lists
{
    class UniqueNumbers
    {
        public static void Run()
        {
            var numbers = new List<int>();
            var unique = new List<int>();
            while (true)
            {
                
                Console.WriteLine("Enter a number or 'QUIT' to exit:");
                var input = Console.ReadLine();

                if (input.ToUpper() == "QUIT")
                    break;
                
                numbers.Add(Convert.ToInt32(input));
            }

            foreach(var number in numbers)
            {
                if (!unique.Contains(number))
                    unique.Add(number);
            }

            Console.WriteLine("Unique Numbers:");
            foreach (var number in unique)
                Console.WriteLine(number);
        }
    }
}
