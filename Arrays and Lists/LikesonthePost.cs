using System;
using System.Collections.Generic;

/* When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern.
*/

namespace Beginner_Exercises.Arrays_and_Lists
{
    class LikesonthePost
    {
        public static void Run()
        {
            var UserName = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a UserName:");
                var input = Console.ReadLine();
                if(!String.IsNullOrWhiteSpace(input))
                {
                    UserName.Add(input);
                }
                else
                {
                    if (UserName.Count == 1)
                    {
                        Console.WriteLine(UserName[0] + " likes your post.");
                        break;
                    }
                    else
                        if (UserName.Count == 2)
                    {
                        Console.WriteLine(UserName[0] + " and " + UserName[1] + " like your post.");
                        break;
                    }
                    else if (UserName.Count > 2)
                    {
                        Console.WriteLine(UserName[0] + " , " + UserName[1] + " and " + (UserName.Count - 2) + " others like your post.");
                        break;
                    }
                    else break;
                }

            }


            
        }
    }
}
