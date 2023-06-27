using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsInfo = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsInfo.ContainsKey(name))
                {
                    studentsInfo.Add(name, new List<double>());
                }

                studentsInfo[name].Add(grade);
            }

            foreach (var student in studentsInfo)
            {
                double averageGrade = student.Value.Sum() / student.Value.Count();
                if (averageGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}
