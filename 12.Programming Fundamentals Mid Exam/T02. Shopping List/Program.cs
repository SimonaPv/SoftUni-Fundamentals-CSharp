using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine()
                .Split('!')
                .ToList();
            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] array = input.Split(' ');

                if (array[0] == "Urgent")
                {
                    if (products.Contains(array[1]) == false)
                    {
                        products.Insert(0, array[1]);
                    }
                }

                else if (array[0] == "Unnecessary")
                {
                    if (products.Contains(array[1]) == true)
                    {
                        products.Remove(array[1]);
                    }
                }

                else if (array[0] == "Correct")
                {
                    if (products.Contains(array[1]) == true)
                    {
                        int index = products.IndexOf(array[1]);
                        products.Remove(array[1]);
                        products.Insert(index, array[2]);
                    }
                }

                else if (array[0] == "Rearrange")
                {
                    if (products.Contains(array[1]) == true)
                    {
                        products.Remove(array[1]);
                        products.Add(array[1]);
                    }
                }

                input = Console.ReadLine(); 
            }

            Console.WriteLine(string.Join(", ", products));
        }
    }
}
