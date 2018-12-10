using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int vehicleSpeed;

            Console.WriteLine("What is the speed limit?");
            speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("How fast is the car going");
            vehicleSpeed = int.Parse(Console.ReadLine());

            if (vehicleSpeed <= speedLimit)
            {
                Console.WriteLine("Good Job!");
            }

            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (vehicleSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit Points:" + demeritPoints);
            }
        }
    }
}
