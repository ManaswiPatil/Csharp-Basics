using System;

/*Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
 */

namespace Beginner_Exercises.Control_Flow
{
    class DivisiblebyThree
    {
        public static void Run()
        {
            int count = 0;
            for (var i = 0; i <100; i++)
            {
                if (i % 3 == 0)
                    count += 1;
            }

            Console.WriteLine("Between 1 to 100 "+count+" numbers are divisible by 3.");
        }
    }
}
