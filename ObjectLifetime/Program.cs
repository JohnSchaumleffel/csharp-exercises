using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            /*
            myCar.Make = "Nissan";
            myCar.Model = "Skyline";
            myCar.Year = 1998;
            myCar.Color = "Gunmetal Gray";
            */

            Car myThirdCar = new Car("Nissan", "GTR", 2018, "Black");

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            Console.ReadLine();

            
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Make = "Toyota";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;

        }

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            
        }

    }
}
