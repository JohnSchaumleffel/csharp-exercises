using System;

namespace MPGCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MPGCalculator calc = new MPGCalculator();
            calc.CalculateMPG();
        }

        public class MPGCalculator
        {
            double miles_driven;
            double gas_consumed;
            string input_miles_driven;
            string input_gas_consumed;
            double miles_per_gallon;


            public void CalculateMPG()
            {
                Console.WriteLine("How many miles have you driven?");
                input_miles_driven = Console.ReadLine();
                miles_driven = double.Parse(input_miles_driven);

                Console.WriteLine("How many gallons of gas were consumed?");
                input_gas_consumed = Console.ReadLine();
                gas_consumed = double.Parse(input_gas_consumed);

                miles_per_gallon = (miles_driven / gas_consumed);
                Console.WriteLine("Your miles per gallon is " + miles_per_gallon);
                Console.ReadLine();
            }
        }


    }
}
