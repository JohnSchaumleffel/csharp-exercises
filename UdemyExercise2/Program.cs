using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Please enter a number.");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }

            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
