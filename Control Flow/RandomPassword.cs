using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Exercises.Control_Flow
{
    class RandomPassword
    {
        const int passwordLength = 10;
        public static void Run()
        {
            var random = new Random();

            var buffer = new char[passwordLength];
            
            for(var i = 0; i < passwordLength; i++)
                buffer[i] = (char)random.Next(97, 122);

            Console.WriteLine(buffer);
        }
    }
}
