using System;

/*Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
 * If the user guesses the number, display “You won"; otherwise, display “You lost". 
 * (To make sure the program is behaving correctly, you can display the secret number on the console first.)
 */

namespace Beginner_Exercises.Control_Flow
{
    class GuessTheNumber
    {
        public static void Run()
        {
            var random = new Random();
            var computer = random.Next(1, 10);
            var lives = 4;

            while(lives > 0)
            {
                Console.WriteLine("You Have " + lives + " lives left.");
                Console.WriteLine("Guess the number:");
                var user = Convert.ToInt32(Console.ReadLine());

                if (user == computer)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                else
                    lives -= 1;
            }

           if (lives == 0)
                Console.WriteLine("You Lost. The number is " + computer);

        }
    }
}
