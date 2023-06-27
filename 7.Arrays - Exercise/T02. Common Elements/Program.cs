using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //my code
            string[] first = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] second = Console.ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = 0; i < second.Length; i++)
            {
                for (int s = 0; s < first.Length; s++)
                {
                    if (first[s] == second[i])
                    {
                        Console.Write(first[s] + " ");
                        break;
                    }
                }
            }       
        }
    }
} //softUni's code
//string[] first = Console.ReadLine()
//.Split(' ')
//.ToArray();

//string[] second = Console.ReadLine()
//.Split(' ')
//.ToArray();

//for (int i = 0; i < second.Length; i++)
//{
//
//for (int s = 0; s < first.Length; s++)
//{
//
//if (first[s] == second[i])
//{
//Console.Write(first[s] + " ");
//}
//}
//}
//}
//}
//}
