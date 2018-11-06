using System;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Add(4, 8));
            Add(10, 8, 2);
            GreetUser();
            Console.ReadLine();
        }

        public static void GreetUser ()
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Add(int numone, int numtwo)
        {
            return numone + numtwo;
        }

        public static void Add(int numone, int numtwo, int numthree)
        {
            Console.WriteLine(numone + numtwo + numthree);
        }
    }
}
