using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int power = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    sb.Append('>');
                }
                else if (power == 0)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    power--;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
