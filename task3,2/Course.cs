using System;
using System.Collections.Generic;
using System.Text;

namespace task3_2
{
    internal class Course
    {
       
        public string Name { get; set; }
        public string Instructor { get; set; }

        public Course(string name, string instructor)
        {
            Name = name;
            Instructor = instructor;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Course: {Name}, Instructor: {Instructor}");
        }
    }
}
