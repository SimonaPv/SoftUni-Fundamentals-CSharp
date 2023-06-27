using System;
using System.Collections.Generic;

namespace T04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] student = input.Split(' ');

                Student person = new Student(student[0], student[1], student[2], student[3]);
                studentList.Add(person);

                input = Console.ReadLine();
            }

            string town = Console.ReadLine();

            foreach (Student student in studentList)
            {
                if (town == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, string age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string HomeTown { get; set; }
    }
}
