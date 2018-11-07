using System;

namespace Class2PracticeProblems
{
    public class ExerciseThree
    {
        public static void Run()
        {
            //allow for certain number
            int maxNumbers = 6;

            int[] nums = new int[maxNumbers];

            nums = [1, 1, 2, 3, 5, 8];

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}