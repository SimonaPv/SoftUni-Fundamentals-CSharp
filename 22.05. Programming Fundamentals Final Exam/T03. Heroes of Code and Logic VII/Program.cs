using System;
using System.Collections.Generic;

namespace T03._Heroes_of_Code_and_Logic_VII
{
    class Points
    {
        public Points(int hP, int mP)
        {
            this.HP = hP;
            this.MP = mP;
        }

        public int HP { get; set; }
        public int MP { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Points> heroes = new Dictionary<string, Points>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine()
                    .Split();
                heroes.Add(array[0], new Points(int.Parse(array[1]), int.Parse(array[2])));
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] action = input.Split(" - ");
                string name = action[1];

                if (action[0] == "CastSpell")
                {
                    heroes[name].MP = CastSpell(name, heroes[name].MP, int.Parse(action[2]), action[3]);
                }

                else if (action[0] == "TakeDamage")
                {
                    heroes[name].HP = TakeDamage(name, heroes[name].HP, int.Parse(action[2]), action[3]);

                    if (heroes[name].HP <= 0)
                    {
                        heroes.Remove(name);
                    }
                }

                else if (action[0] == "Recharge")
                {
                    heroes[name].MP = Recharge(name, int.Parse(action[2]), heroes[name].MP);
                }

                else if (action[0] == "Heal")
                {
                    heroes[name].HP = Heal(name, int.Parse(action[2]), heroes[name].HP);
                }

                input = Console.ReadLine();
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }

        static int CastSpell(string name, int mP, int neededMP, string spell)
        {
            if (mP >= neededMP)
            {
                Console.WriteLine($"{name} has successfully cast {spell} and now has {mP - neededMP} MP!");
                return mP - neededMP;
            }
            else
            {
                Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
                return mP;
            }
        }

        static int TakeDamage(string name, int hP, int damage, string attacker)
        {
            int damageAttack = hP - damage;

            if (damageAttack > 0)
            {
                Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {damageAttack} HP left!");
                return damageAttack;
            }
            else
            {
                Console.WriteLine($"{name} has been killed by {attacker}!");
                return damageAttack;
            }
        }

        static int Recharge(string name, int amount, int mP)
        {
            int sum = amount + mP;

            if (sum > 200)
            {
                int recharge = 200 - mP;
                mP = 200;
                Console.WriteLine($"{name} recharged for {recharge} MP!");
                return mP;
            }
            else
            {
                mP = sum;
                Console.WriteLine($"{name} recharged for {amount} MP!");
                return mP;
            }
        }

        static int Heal(string name, int amount, int hP)
        {
            int sum = amount + hP;

            if (sum > 100)
            {
                int recharge = 100 - hP;
                hP = 100;
                Console.WriteLine($"{name} healed for {recharge} HP!");
                return hP;
            }

            else
            {
                hP = sum;
                Console.WriteLine($"{name} healed for {amount} HP!");
                return hP;
            }
        }
    }
}
