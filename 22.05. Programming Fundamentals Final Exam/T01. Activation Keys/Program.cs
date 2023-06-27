using System;

namespace T01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string[] command = Console.ReadLine()
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Generate")
            {
                if (command[0] == "Contains")
                {
                    ContainsMethod(key, command[1]);
                }

                else if (command[0] == "Flip")
                {
                    if (command[1] == "Upper")
                    {
                        key = Upper(key, int.Parse(command[2]), int.Parse(command[3]));
                    }
                    else
                    {
                        key = Lower(key, int.Parse(command[2]), int.Parse(command[3]));
                    }
                }

                else if (command[0] == "Slice")
                {
                    key = Slice(key, int.Parse(command[1]), int.Parse(command[2]));
                }

                command = Console.ReadLine()
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Your activation key is: {key}");
        }

        static void ContainsMethod(string key, string word)
        {
            if (key.Contains(word))
            {
                Console.WriteLine($"{key} contains {word}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }

        static string Upper(string key, int startIndex, int endIndex)
        {
            string original = key.Substring(startIndex, endIndex - startIndex);
            string newLetters = original.ToUpper();

            key = key.Replace(original, newLetters);

            Console.WriteLine(key);

            return key;
        }

        static string Lower(string key, int startIndex, int endIndex)
        {
            string original = key.Substring(startIndex, endIndex - startIndex);
            string newLetters = original.ToLower();

            key = key.Replace(original, newLetters);

            Console.WriteLine(key);

            return key;
        }

        static string Slice(string key, int startIndex, int endIndex)
        {
            key = key.Remove(startIndex, endIndex - startIndex);

            Console.WriteLine(key);

            return key;
        }
    }
}
