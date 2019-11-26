using System;
using System.Runtime.InteropServices;

namespace Survey
{
    class Program
    {
        /*Create a simple three-question survey
         * - what is your name?
         * - how old are you?
         * - what month were you born in?
         * Output the answers back into the console.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer(); 
            
            Console.WriteLine("How old are you");
            var age = TryAnswer();
            
            Console.WriteLine("What month were you born in?");
            var birthMonth = TryAnswer();
            
            Console.WriteLine("Your name is {0}, you are {1} years old, and were born in {2}.", name, age, birthMonth);

            if (birthMonth == "march")
            {
                Console.WriteLine("You are an Aries.");
            }
            else if (birthMonth == "april")
            {
                Console.WriteLine("You are a Taurus.");
            }
            else if (birthMonth == "may")
            {
                Console.WriteLine("You are a Gemini.");
            }
            else
            {
                Console.WriteLine("Cannot determine zodiac sign.");
            }
        }

        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again.");
                return Console.ReadLine();
            }

            return answer;
        }
        
    }
}