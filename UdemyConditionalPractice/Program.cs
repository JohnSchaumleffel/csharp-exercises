﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyConditionalPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // If and Else Statments
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }

            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }

            else
            {
                Console.WriteLine("It's evening.");
            }
            

            //Boolean Operator

            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
            Console.ReadLine();
            */

            //Switch Opereator

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's the perfect time to go to the beach.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }
            
        }
    }
}