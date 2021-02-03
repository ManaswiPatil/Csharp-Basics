using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
 * Display the reversed name on the console.
 */ 

namespace Beginner_Exercises.Arrays_and_Lists
{
    class ReverseString
    {
        public static void Run()
        {
            
            Console.WriteLine("Enter your Name:");
            var input = Console.ReadLine();

            char[] reversename = new char[input.Length];

            for(var i = input.Length; i>0; i--)
            {
                reversename[input.Length - i] = input[i - 1];
            }

            string reversedname = new string(reversename);
            Console.WriteLine(reversedname);
            
        }
    }
}
