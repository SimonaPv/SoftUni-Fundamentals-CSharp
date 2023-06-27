using System;
using System.Collections.Generic;

namespace T01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames = new List<string>();

            foreach (var username in input)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;

                    for (int i = 0; i < username.Length; i++)
                    {
                        if (!(char.IsLetterOrDigit(username[i]) || username[i] == '-' || username[i] == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid == true)
                    {
                        validUsernames.Add(username);
                    }
                }
            }
            Console.WriteLine(string.Join("\n", validUsernames));
        }
    }
}
