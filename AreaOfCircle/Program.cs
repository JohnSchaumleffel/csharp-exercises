using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            double area;
            string input;
            double radius;

            //loop for wrong input
            do
            {
                //ask for input
                Console.WriteLine("What is the radius of the circle?");
                //retrieve input
                input = Console.ReadLine();
                //change input type and variable name
                radius = double.Parse(input);
                //validation for radius
                if (radius <= 0)
                {
                    Console.WriteLine("Radius cannot be negative or zero.");
                    Console.ReadLine();
                }
                else
                {
                    //do math for area
                    area = 3.14 * radius * radius;
                    //write answer
                    Console.WriteLine("The area of the circle is " + area);
                    Console.ReadLine();
                }
            } while (radius <= 0);
        }
    }
}
