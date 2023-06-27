using System;

namespace T01._Password_Reset
{
    internal class Program
    {
        static string TakeOdd(string password)
        {
            string newPassword = string.Empty;

            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newPassword += password[i];
                }
            }

            password = newPassword;
            Console.WriteLine(password);
            return password;
        }

        static string Cut(string password, int index, int length)
        {
            password = password.Remove(index, length);
            Console.WriteLine(password);
            return password;
        }

        static string Substitute(string password, string substring, string substitute)
        {
            if (password.Contains(substring))
            {
                password = password.Replace(substring, substitute);
                Console.WriteLine(password);
            }

            else
            {
                Console.WriteLine("Nothing to replace!");
            }

            return password;
        }

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] command = input.Split();

                if (command[0] == "TakeOdd")
                {
                    password = TakeOdd(password);
                }

                else if (command[0] == "Cut")
                {
                    password = Cut(password, int.Parse(command[1]), int.Parse(command[2]));
                }

                else if (command[0] == "Substitute")
                {
                    password = Substitute(password, command[1], command[2]);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
