using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message
 * and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
 */

namespace Beginner_Exercises.Arrays_and_Lists
{
    class SortNumbers
    {
        public static void Run()
        {
            var numbers = new List<int>();

            while(numbers.Count<5)
            {
                Console.WriteLine("Enter a number:");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("Number already exists.");
                    continue;
                }else
                    numbers.Add(number);

            }

            numbers.Sort();
            Console.WriteLine("Numbers are sorted as:");
            foreach (var num in numbers)
                Console.WriteLine(num);

        }
    }
}
