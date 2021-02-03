using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
 * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
 * If the user doesn't provide any values, consider it as invalid time.
 */
namespace Beginner_Exercises.Working_With_Text
{
    class TimeFormatValidation
    {
        public static void Run()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00):");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
                return;
            }
            
            var time = input.Split(':');
            if (time.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var hours = Convert.ToInt32(time[0]);
            var minutes = Convert.ToInt32(time[1]);

            if ((hours >= 0 && hours < 24) && (minutes >= 0 && minutes <= 59))
            {
                Console.WriteLine("OK");
            }
            else
                Console.WriteLine("Invalid Time");







        }
    }
}
