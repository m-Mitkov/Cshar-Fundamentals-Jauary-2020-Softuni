using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace bossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex decryptingPattern = new Regex(@"\|([A-Z]{4,})\|:(#)([A-Za-z]+ [A-Za-z]+)\2");
                                   // group 1 - name, group 2 - '#', group 3 - title    
            
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string currentBoss = Console.ReadLine();

                if (decryptingPattern.IsMatch(currentBoss))
                {
                    string name = decryptingPattern.Match(currentBoss).Groups[1].ToString();
                    string title = decryptingPattern.Match(currentBoss).Groups[3].ToString();

                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }

                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
