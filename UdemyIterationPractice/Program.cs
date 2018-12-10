using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIterationPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //For Loops
            /*
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    
                }
                
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadLine();
            

            //Foreach Loops

            var name = "John Smith";
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }
            
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            

            //While Loops

            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;
            }
            */

            while (true)
            {
                Console.Write("Type your name:");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }

        }
        
    }
}
