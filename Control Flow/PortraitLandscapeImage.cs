using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner_Exercises.Control_Flow
{
    class PortraitLandscapeImage
    {
        public static void Run()
        {
            Console.WriteLine("Enter Width of an Image in px: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height of an Image in px: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? "Landscape" : "Portrait";
            Console.WriteLine("Image orientatin is " + orientation);

        }
    }
}
