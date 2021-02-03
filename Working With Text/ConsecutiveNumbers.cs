using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. 
 * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
 */

namespace Beginner_Exercises.Working_With_Text
{
    class ConsecutiveNumbers
    {
        public static void Run()
        {
            Console.WriteLine("enter a few numbers separated by a hyphen '-' e.g. '5 - 6 - 7 - 8 - 9':");
            var input = Console.ReadLine();

            var numbers = input.Split('-');

            var numList = new List<int>();
            foreach(var number in numbers)
                numList.Add(Convert.ToInt32(number));

            numList.Sort();
            var IsConsecutive = true;

            for(var i=1; i<numList.Count; i++)
            {
                if(numList[i] != numList[i-1]+1)
                {
                    IsConsecutive = false;
                    break;
                }
            }

            var result = IsConsecutive ? "Consecutive" : "Non-Consecutive";
            Console.WriteLine(result);

        }
    }
}
