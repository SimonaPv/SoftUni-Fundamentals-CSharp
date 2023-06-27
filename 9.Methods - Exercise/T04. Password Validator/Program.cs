using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Password_Validator
{
    internal class Program
    {
        
        static bool ValidPassLength(string password)
        {
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                return false;
            }
            return true;    
        }

        static bool ValidPassLett(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        static bool ValidPassSymb(string password)
        {
            int countOfNums = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol) == true)
                {
                    countOfNums++;
                }
            }

            if (countOfNums < 2)
            {
                return false;
            }
            return true; 
        }

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (ValidPassLength(password) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (ValidPassLett(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (ValidPassSymb(password) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (ValidPassLength(password) == true && ValidPassSymb(password) == true && ValidPassLett(password) == true)
            { 
                Console.WriteLine("Password is valid"); 
            }
        }
    }
}
