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
            AddingEvenNumbers adding = new AddingEvenNumbers();
            adding.GetSum();
            Console.WriteLine(sum);
            Console.ReadLine();
        }
        /*
        public static List<int> SetupIntegerList()
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 30; i++)
                integers.Add(i);
            return integers;
        }
        */
        public class AddingEvenNumbers
        {
            //List<int> integers = SetupIntegerList();
            int sum = GetSumOfEvenIntegers();
            List<int> integers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            
            

            public int GetSum()
            {
                /*public static int*/
                GetSumOfEvenIntegers();
                {
                    sum = 0;
                    foreach (int integer in integers)
                    {
                        if (integer % 2 == 0)
                            sum += integer;
                    }

                    return sum;
                }

            }
        }

    }
}

