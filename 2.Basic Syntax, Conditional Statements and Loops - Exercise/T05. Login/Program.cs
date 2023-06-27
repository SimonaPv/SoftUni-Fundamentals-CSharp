using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int userLength = username.Length - 1;
            string password = "";

            for (int i = userLength; i >= 0; i--)
            {
                password += username[i];
            }

            int count = 0;
            string input = Console.ReadLine();

            while (input != password)
            {
                count++;
                if (count > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }

            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
