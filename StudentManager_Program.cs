using System;

namespace StudentManager
{
    class Program
    {
        /* Get Student Name and Grade from console input
         * Able to handle any number of students
         * Display all student names and grades once the user finishes adding students
         */
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse((Console.ReadLine()));

            var studentNames = new string[studentCount];
            var studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: ");
                studentNames[i] = Console.ReadLine();
                
                Console.WriteLine("Student Grade: ");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}
