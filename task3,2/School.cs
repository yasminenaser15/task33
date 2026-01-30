using System;
using System.Collections.Generic;
using System.Text;

namespace task3_2
{
    internal class School
    {
       private List<Student> students=new List<Student>();
       private List<Course> courses=new List<Course>();

        public Student this[int index]
        {
            get
            {
                if (index >= 0 && index < students.Count)
                    return students[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < students.Count)
                {
                    students[index] = value;
                }
            }
        }
        public void AddStudent (Student student)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if(student.Id== students[i].Id)
                {
                    Console.WriteLine("Student is aleardy exists");
                    return;
                }
            }
            students.Add(student);

        }
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void EnrollStudentInCourse(int studentID, string courseName)
        {
            Student student = null;
            Course course = null;

            for (int i = 0; i < students.Count; i++)
            {
                if (studentID == students[i].Id)
                {
                    student=students[i];
                    break;
                }
            }
            for (int i = 0; i < courses.Count; i++)
            {
                if (courseName == courses[i].Name)
                {
                    course = courses[i];
                    break;
                }
            }
            if (student == null)
            {
                Console.WriteLine("student not exists");
                return;
            }
            if(course == null)
            {
                Console.WriteLine("course not found");
                return;
            }

            student.EnrollCourse(courseName);
            Console.WriteLine($"{student.Name} enrolled in {courseName}");

        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("\n Courses List:");

            for (int i = 0; i < courses.Count; i++)
            {
                courses[i].DisplayDetails();
            }
        }

        public void DisplayAllStudents()
        {
            Console.WriteLine("\n Students List:");

            for (int i = 0; i < students.Count; i++)
            {
                students[i].DisplayDetails();
            }
        }







    }
}
