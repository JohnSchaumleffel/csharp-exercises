using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingEvenNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> integers = SetupIntegerList();
            int sum = GetSumOfEvenIntegers(integers);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static int GetSumOfEvenIntegers(List<int> integers)
        {
            int sum = 0;
            foreach(int integer in integers)
            {
                if (integer % 2 == 0)
                    sum += integer;
            }

            return sum;
        }

        public static List<int> SetupIntegerList()
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 30; i++)
                integers.Add(i);
            return integers;
        }

    }
}

