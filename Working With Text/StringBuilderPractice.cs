using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Exercises.Working_With_Text
{
    class StringBuilderPractice
    {
        /*StringBuilder only provides methods for fast and efficient manipulation of strings. It doesn't have any methods to search in strings. 
        *If you need to search in a string that you're building using a StringBuilder, you need to cover it to a string first: builder.ToString().IndexOf('M').
        **/
        public static void Run()
        {
            var builder = new StringBuilder("Hello World");

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);
           
           

        }
    }
}
