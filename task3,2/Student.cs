using System;
using System.Collections.Generic;
using System.Text;

namespace task3_2
{
    internal class Student
    {
         

        public int Id { get; set; }
        public string Name { get; set; }

        public List<string> Courses { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            Courses = new List<string>();
        }

        public Student(Student student)
        {
            Name = student.Name;
            this.Id = student.Id;
            Courses = new List<string>();
        }

        public void EnrollCourse(string course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
            }
         
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}");
            Console.Write("Courses: ");
            if (Courses.Count == 0)
                Console.WriteLine("No courses");
            else
                Console.WriteLine(string.Join(", ", Courses));
        }


    }
}
