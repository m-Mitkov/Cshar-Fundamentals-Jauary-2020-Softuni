using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternLetters = new Regex(@"[A-Za-z]");
            Regex patternDigits = new Regex(@"[0-9]");

            Dictionary<string, int> runners = new Dictionary<string, int>();

            foreach (var racer in Console.ReadLine().Split(", "))
            {
                runners.Add(racer, 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = "";

                foreach (var letter in patternLetters.Matches(input))
                {
                    name += letter;
                }

                if (runners.ContainsKey(name))
                {
                    int km = 0;

                    foreach (var digit in patternDigits.Matches(input))
                    {
                        km += int.Parse(digit.ToString());
                    }

                    runners[name] += km;
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> winners = runners.OrderByDescending(x => x.Value)
                .Take(3)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"1st place: {winners.Keys.First()}");
            winners.Remove(winners.Keys.First());
            Console.WriteLine($"2nd place: {winners.Keys.First()}");
            winners.Remove(winners.Keys.First());
            Console.WriteLine($"3rd place: {winners.Keys.First()}");
            winners.Remove(winners.Keys.First());

        }
    }
}
