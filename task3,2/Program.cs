namespace task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            // Add Courses
            school.AddCourse(new Course("C#", "Dr. Ahmed"));
            school.AddCourse(new Course("Java", "Dr. Sara"));
            school.AddCourse(new Course("Database", "Dr. Ali"));

            // Add Students
            Student s1 = new Student(1,"yasmine");
            Student s2 = new Student(2,"omar");

            school.AddStudent(s1);
            school.AddStudent(s2);

            // Enroll Students
            school.EnrollStudentInCourse(1, "C#");
            school.EnrollStudentInCourse(1, "Database");
            school.EnrollStudentInCourse(2, "Java");


            // Display Data
            school.DisplayAllStudents();
            school.DisplayAllCourses();

            // Copy Constructor Demo
            Student copyStudent = new Student(s1);
            Console.WriteLine("\n Copied Student (Empty Courses):");
            copyStudent.DisplayDetails();

            // Indexer Demo (Bonus)
            Console.WriteLine(" Access student using indexer:");
            school[0].DisplayDetails();

            Console.ReadLine();
        }
    }
}
