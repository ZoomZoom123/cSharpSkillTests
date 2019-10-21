using System;
using System.Linq;

namespace CSharpFundamentals
{
    public class ArraySkillTest
    {
        /* Create a method which takes an array of integers 
         * and returns the greatest integer value in the array.
         */
        static int[] anArray = { 32, 15, 26, 7, 0, 46, 55};

        public static void Main()
        {
            Console.WriteLine("Largest Integer is: " + LargestInteger());
        }

        public static int LargestInteger()
        {
           int max = anArray[0];

            for (var i = 0; i < anArray.Length; i++)
            {
                if (anArray[i] > max)
                {
                    max = anArray[i];
                }
            }
            return max;
        }
    }
}
