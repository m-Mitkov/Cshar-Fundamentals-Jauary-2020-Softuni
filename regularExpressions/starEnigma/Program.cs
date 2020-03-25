using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace starEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex decriptionKey = new Regex(@"[STAR]", RegexOptions.IgnoreCase);
            Regex decryptingPattern = new Regex(@"@([A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!(A|D)![^@\-!:>]*->(\d+)");

            int numberOfComands = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < numberOfComands; i++)
            {
                string cryptedComand = Console.ReadLine();
                string decryptedMessage = string.Empty;

                int encryptingKey = decriptionKey.Matches(cryptedComand).Count;

                for (int k = 0; k < cryptedComand.Length; k++)
                {
                    decryptedMessage += (char)(cryptedComand[k] - encryptingKey);

                }
                if (decryptingPattern.IsMatch(decryptedMessage))
                {
                    string planetName = decryptingPattern.Match(decryptedMessage).Groups[1].ToString();
                    char typeOfAttack = char.Parse(decryptingPattern.Match(decryptedMessage).Groups[3].ToString());
                    if (typeOfAttack == 'A')
                    {
                        attackedPlanets.Add(planetName);
                    }

                    else if (typeOfAttack == 'D')
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var planet in attackedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
