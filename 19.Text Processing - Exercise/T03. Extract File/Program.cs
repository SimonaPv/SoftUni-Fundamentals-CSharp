using System;

namespace T03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('\\', StringSplitOptions.RemoveEmptyEntries);

            string[] fileName = input[input.Length - 1]
                .Split('.');

            Console.WriteLine("File name: " + fileName[0]);
            Console.WriteLine("File extension: " + fileName[1]);
        }
    }
}
