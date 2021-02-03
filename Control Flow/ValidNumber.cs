using System;

namespace Beginner_Exercises.Control_Flow
{
    class ValidNumber
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number between 1 to 10:" );
            int number = Convert.ToInt32(Console.ReadLine());

            var message = (IsValidNumber(number)) ? "Valid" : "Invalid";

            Console.WriteLine(message);
        }

        static bool IsValidNumber(int number)
        {
            if (0 < number || number <= 10)
            {
                return true;
            }
            else return false;
        }

    }
}
