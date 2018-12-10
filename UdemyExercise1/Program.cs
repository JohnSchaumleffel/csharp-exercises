using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Please choose a number between 1 and 10.");
            number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }

            else
            {
                Console.WriteLine("Invalid");
            }


        }
    }
}
