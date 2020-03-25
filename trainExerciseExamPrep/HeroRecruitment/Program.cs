using System;
using System.Collections.Generic;
using System.Linq;

namespace heroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(" ");

                string toDo = comand[0];

                if (toDo == "End")
                {
                    break;
                }

                string currentHeroName = comand[1];

                if (toDo == "Enroll")
                {
                    if (!heroes.ContainsKey(currentHeroName))
                    {
                        heroes.Add(currentHeroName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{currentHeroName} is already enrolled.");
                    }
                }

                else if (toDo == "Learn")
                {
                    string spell = comand[2];

                    if (!heroes.ContainsKey(currentHeroName))
                    {
                        Console.WriteLine($"{currentHeroName} doesn't exist.");
                    }
                    else
                    {
                        if (heroes[currentHeroName].Contains(spell))
                        {
                            Console.WriteLine($"{currentHeroName} has already learnt {spell}");
                        }
                        else
                        {
                            heroes[currentHeroName].Add(spell);
                        }
                    }
                }

                else if (toDo == "Unlearn")
                {
                    string spell = comand[2];

                    if (!heroes.ContainsKey(currentHeroName))
                    {
                        Console.WriteLine($"{currentHeroName} doesn't exist.");
                    }
                    else
                    {
                        if (!heroes[currentHeroName].Contains(spell))
                        {
                            Console.WriteLine($"{currentHeroName} doesn't know {spell}.");
                        }
                        else
                        {
                            heroes[currentHeroName].Remove(spell);
                        }
                    }
                }
            }

            heroes = heroes.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Heroes:");

            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
