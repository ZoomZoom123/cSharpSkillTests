using System;

namespace PassCode
{
    class Program
    {
        /*Challenge: Pass code
         * Check that the input matches the pass code "secret"
         * Let the user know he/she is authenticated
         */
        
        static void Main(string[] args)
        {
            var userPassCode = ""; 
            
            while (userPassCode != "secret")
            {
                Console.WriteLine("What is the pass code?");
                userPassCode = Console.ReadLine();

                if (userPassCode != "secret")
                {
                    Console.WriteLine("Authentication failed.");
                }
            }
            
            Console.WriteLine("Authentication verified.");
        }
    }
}