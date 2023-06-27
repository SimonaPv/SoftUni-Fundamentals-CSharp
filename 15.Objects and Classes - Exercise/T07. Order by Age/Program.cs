
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();

                Person person = new Person(tokens[0], tokens[1], int.Parse(tokens[2]));
                people.Add(person);

                input = Console.ReadLine();
            }

            foreach (Person person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
    class Person
    {
        public Person(string name, string iD, int age)
        {
            this.Name = name;
            this.ID = iD;
            this.Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} with ID: {ID} is {Age} years old.");
            return sb.ToString();
        }
    }
}
