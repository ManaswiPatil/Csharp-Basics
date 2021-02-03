using System;

/*Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
 * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
 */

namespace Beginner_Exercises.Control_Flow
{
    class Factorial
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number to calculate its Factorial:");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;

            for (var i =number; i>0; i--)
                 factorial *= i;

            Console.WriteLine(number + "!=" + factorial);
        }
    }
}
