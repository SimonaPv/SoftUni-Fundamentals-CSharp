using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shelf = Console.ReadLine()
                .Split('&')
                .ToList();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] array = input.Split(new string[] { " | " }, StringSplitOptions.None);

                if (array[0] == "Add Book")
                {
                    if (shelf.Contains(array[1]) == false)
                    {
                        shelf.Insert(0, array[1]);
                    }
                }

                else if (array[0] == "Take Book")
                {
                    if (shelf.Contains(array[1]) == true)
                    {
                        shelf.Remove(array[1]);
                    }
                }

                else if (array[0] == "Swap Books")
                {
                    if (shelf.Contains(array[1]) == false || shelf.Contains(array[2]) == false)
                    {
                        continue;
                    }

                    int index1 = shelf.IndexOf(array[1]);   
                    int index2 = shelf.IndexOf(array[2]);

                    shelf[index1] = array[2];
                    shelf[index2] = array[1];
                }

                else if (array[0] == "Insert Book")
                {
                    if (shelf.Contains(array[1]) == false)
                    {
                        shelf.Add(array[1]);
                    }
                }

                else if (array[0] == "Check Book")
                {
                    if (int.Parse(array[1]) < 0 || int.Parse(array[1]) > shelf.Count - 1)
                    {
                        continue;
                    }
                    Console.WriteLine(shelf[int.Parse(array[1])]);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shelf));
        }
    }
}
