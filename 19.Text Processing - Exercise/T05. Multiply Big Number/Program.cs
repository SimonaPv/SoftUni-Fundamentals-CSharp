using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace T05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int smallNum = int.Parse(Console.ReadLine());

            if (smallNum == 0) //0*0 = 0 ==> nqma nujda ot dopulnitelni proverki
            {
                Console.WriteLine("0");
                return;
            }

            StringBuilder sb = new StringBuilder();
            int reminder = 0; //pazi ostatuk

            for (int i = bigNum.Length - 1; i >= 0; i--) //zashtoto umnojenieto se pravi otlqvo nadqsno
            {
                char lastDigit = bigNum[i];
                int lastDigitAsNum = int.Parse(lastDigit.ToString()); //vzimame poslednoto chislo i go prevrushtame v int

                int result = lastDigitAsNum * smallNum + reminder;

                sb.Append(result % 10); //zapazvame samo vtorata cifra ot rezultata
                reminder = result / 10; //purvata e ostatuk
            }

            if (reminder != 0) //ako ima ostanul ostatuk go dobavqme
            {
                sb.Append(reminder);
            }

            StringBuilder reversedSb = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--) //obrushtame chislata, zashtoto sa zapazeni v obraten red
            {
                reversedSb.Append(sb[i]);
            }

            Console.WriteLine(reversedSb);
        }
    }
}
