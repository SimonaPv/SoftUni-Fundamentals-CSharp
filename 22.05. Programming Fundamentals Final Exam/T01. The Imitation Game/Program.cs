using System;

namespace T01._The_Imitation_Game
{
    internal class Program
    {
        static string Move(string message, int numOfLetters)
        {
            while (numOfLetters > 0)
            {
                message += message[0];
                message = message.Remove(0, 1);
                numOfLetters--;
            }
            
            return message;
        }

        static string Insert(string message, int index, string value)
        {
            message = message.Insert(index, value);
            return message;
        }

        static string ChangeAll(string message, string substring, string replacement)
        {
            message = message.Replace(substring, replacement);  
            return message;
        }

        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Decode")
            {
                string[] command = input.Split("|");

                if (command[0] == "Move")
                {
                    message = Move(message, int.Parse(command[1]));
                }

                else if (command[0] == "Insert")
                {
                    message = Insert(message, int.Parse(command[1]), command[2]);
                }

                else if (command[0] == "ChangeAll")
                {
                    message = ChangeAll(message, command[1], command[2]);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
