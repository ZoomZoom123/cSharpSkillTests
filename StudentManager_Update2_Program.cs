﻿using System;
using System.Collections.Generic;

namespace StudentManager
{
    class Program
    {
        /* Class size is dynamic
         * Able to add new students at any point in time
         */
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;
            
            while (adding)
            {
                var newStudent = new Student();
                
                Console.Write("Student Name: ");
                newStudent.Name = Console.ReadLine();
                
                Console.Write("Student Grade: ");
                newStudent.Grade = int.Parse(Console.ReadLine());
                
                Console.Write("Student Birthday: ");
                newStudent.Birthday = Console.ReadLine();
                
                Console.Write("Student Address: ");
                newStudent.Address = Console.ReadLine();
                
                Console.Write("Student Phone Number: ");
                newStudent.Phone = int.Parse(Console.ReadLine());
                
                students.Add(newStudent);
                
                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }
        
        
    }

    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public int Phone;

    }
}
