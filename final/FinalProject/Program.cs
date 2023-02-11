using System;

namespace StudentRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter student ID: ");
            int studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.WriteLine("Enter course code: ");
            int courseCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter teacher name: ");
            string teacherName = Console.ReadLine();

            Console.WriteLine("Enter teacher subject: ");
            string teacherSubject = Console.ReadLine();

            Console.WriteLine("Enter department name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter department code: ");
            int departmentCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter university name: ");
            string universityName = Console.ReadLine();

            Console.WriteLine("Enter university address: ");
            string universityAddress = Console.ReadLine();

            Console.WriteLine("Enter assignment name: ");
            string assignmentName = Console.ReadLine();

            Console.WriteLine("Enter assignment course code: ");
            int assignmentCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter assignment description: ");
            string assignmentDescription = Console.ReadLine();

            Console.WriteLine("Enter grade score: ");
            int gradeScore = int.Parse(Console.ReadLine());

            Student student = new Student(studentName, studentId);
            Course course = new Course(courseName, courseCode);
            Teacher teacher = new Teacher(teacherName, teacherSubject);
            Department department = new Department(departmentName, departmentCode);
            University university = new University(universityName, universityAddress);
            Assignment assignment = new Assignment(assignmentName, assignmentCode, assignmentDescription);
            Grade grade = new Grade(student, course, assignment, gradeScore);
            Transcript transcript = new Transcript(student, university, grade);

            Console.WriteLine(transcript.ToString());
            Console.ReadLine();
        }
    }

    
}


