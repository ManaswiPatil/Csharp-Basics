using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. 
 *For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input.
 *So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
 */


namespace Beginner_Exercises.Working_With_Text
{
    class PascalCase
    {
        public static void Run()
        {
            Console.WriteLine("Enter a few words separated by a space");
            var name = Console.ReadLine();
            var input = name.Split(' ');

            if (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach(var word in input)
            {
                var PascalName = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += PascalName;
            }

            Console.WriteLine(variableName);
            
        }
    }
}
