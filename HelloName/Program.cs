using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string name;

            Console.WriteLine("What is your name?");
            input = Console.ReadLine();
            name = (input);
            Console.WriteLine("Hello " + name);
            Console.ReadLine();
        }
    }
}
