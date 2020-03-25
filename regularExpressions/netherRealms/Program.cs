using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace netherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternForName = new Regex(@"[^\d*\/+-\.]");
            Regex patternForBaseDamage = new Regex(@"((\+|\-)?(\d+(\.\d+)?))");  // + -
            Regex multiplicationAndDivision = new Regex(@"[/|\*]");  // * /

            List<string> demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .ToList();

            for (int i = 0; i < demons.Count; i++)
            {
                string currentDemon = demons[i];

                string name = GetName(currentDemon, patternForName);
                double health = GetHealt(name);
                double damage = GetDamage(currentDemon, patternForBaseDamage, multiplicationAndDivision);

                Console.WriteLine($"{currentDemon} - {health} health, {damage:F2} damage");
            }
        }
        public static double GetDamage(string currentDemon, Regex baseDamage, Regex extraDamage)
        {
            List<Match> matchedNumbers = baseDamage.Matches(currentDemon).ToList();
            double damage = 0;

            if (matchedNumbers.Count > 0)
            {
                foreach (var number in matchedNumbers)
                {
                    damage += double.Parse(number.ToString());
                }
            }

            MatchCollection multiAndDivis = extraDamage.Matches(currentDemon);
            if (multiAndDivis.Count > 0)
            {
                foreach (var symbol in multiAndDivis)
                {
                    if (symbol.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else if (symbol.ToString() == "/")
                    {
                        damage /= 2;
                    }
                }
            }
            return damage;
        }

        public static string GetName(string currentDemon, Regex patternForName)
        {
            string name = "";

            for (int i = 0; i < currentDemon.Length; i++)
            {
                string currentChar = currentDemon[i].ToString();

                if (patternForName.IsMatch(currentChar))
                {
                    name += currentChar;
                }
            }
            return name;
        }

        public static double GetHealt(string name)
        {
            double health = 0;
            for (int i = 0; i < name.Length; i++)
            {
                health += name[i];
            }
            return health;
        }


    }
}
