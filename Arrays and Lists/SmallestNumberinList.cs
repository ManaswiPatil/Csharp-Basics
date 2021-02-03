using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Exercises.Arrays_and_Lists
{
    class SmallestNumberinList
    {
        public static void Run()
        {
            var numbers = new List<string>();

            while(true)
            {
                Console.WriteLine("Enter comma seperated 5 numbers:");
                var input = Console.ReadLine();

                numbers = input.Split(',').ToList();

                if (string.IsNullOrEmpty(input) || numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }
                else
                    break;
            }

            var numList = new List<int>();
            foreach(var num in numbers)
            {
                numList.Add(Convert.ToInt32(num));
            }

            numList.Sort();
            Console.WriteLine("Smallest 3 numbers are:");
            for (var i = 0; i < 3; i++)
                Console.WriteLine(numList[i]);
            


        }
    }
}
