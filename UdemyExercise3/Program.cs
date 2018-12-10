using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            int width;

            Console.WriteLine("Please enter the height of the image.");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the image.");
            width = int.Parse(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("The image is a portrait.");
            }

            else
            {
                Console.WriteLine("The image is a landscape.");
            }
        }
    }
}
