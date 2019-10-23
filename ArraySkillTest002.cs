using System;

namespace CSharpFundamentals
{
    public class ArraySkillTest
    {
        /* Create a method which takes an array of integers 
         * and returns the greatest integer value in the array.
         */

        public static void Main()
        {
            Console.WriteLine("Largest Integer is: " + LargestInteger(new int[] { 32, 15, 26, 7, 0, 46, 55 }));
        }

        public static int LargestInteger(int[] arrayNumbers)
        {
           int max = arrayNumbers[0];

            for (var i = 0; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] > max)
                {
                    max = arrayNumbers[i];
                }
            }
            return max;
        }
    }
}
