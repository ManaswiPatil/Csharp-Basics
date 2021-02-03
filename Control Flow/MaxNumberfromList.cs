using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Exercises.Control_Flow
{
    class MaxNumberfromList
    {
        public static void Run()
        {
            Console.WriteLine("Enter series of 5 Numbers seperated by comma:");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);  //Assuming first number is max.

            foreach(var number in numbers)
            {
                var num = Convert.ToInt32(number);
                if (max < num)
                    max = num;
            }

            Console.WriteLine("Max number is " + max);


        }
    }
}
