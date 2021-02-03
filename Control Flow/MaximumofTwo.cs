/*Write a program which takes two numbers from the console and displays the maximum of the two.
 */

using System;

namespace Beginner_Exercises.Control_Flow
{
    class MaximumofTwo
    {
        public static void Run()
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = a > b ? a : b;
            Console.WriteLine("Maximum of {0} anb {1} is {2}", a, b, max);
        }
        
    }
}
