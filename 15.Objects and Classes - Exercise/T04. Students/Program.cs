using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                students.Add(student);
            }

            List<Student> sortedStudents = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Student studs in sortedStudents)
            {
                Console.WriteLine($"{studs.FirstName} {studs.LastName}: {studs.Grade:f2}");
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
