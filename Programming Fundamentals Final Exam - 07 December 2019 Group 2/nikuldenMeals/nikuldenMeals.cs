using System;
using System.Linq;
using System.Collections.Generic;

namespace nikuldenMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guestsMeals = new Dictionary<string, List<string>>();

            int countUnlikedMeals = 0;

            while (true)
            {
                string[] comand = Console.ReadLine().Split("-");

                if (comand[0] == "Stop")
                {
                    break;
                }

                string LikeOrUnlike = comand[0];
                string guest = comand[1];
                string meal = comand[2];

                if (LikeOrUnlike == "Like")
                {
                    if (!guestsMeals.ContainsKey(guest))
                    {
                        guestsMeals.Add(guest, new List<string>());
                        guestsMeals[guest].Add(meal);
                    }
                    else
                    {
                        if (!guestsMeals[guest].Contains(meal))
                        {
                            guestsMeals[guest].Add(meal);
                        }
                    }
                }

                else if (LikeOrUnlike == "Unlike")
                {
                    if (!guestsMeals.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }

                    else
                    {
                        if (guestsMeals[guest].Contains(meal))
                        {
                            guestsMeals[guest].Remove(meal);
                            countUnlikedMeals++;

                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                    }
                }
            }

            guestsMeals = guestsMeals.OrderByDescending(x => x.Value.Count)
                .ThenBy(y => y.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in guestsMeals)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }

            Console.WriteLine($"Unliked meals: {countUnlikedMeals}");
        }
    }
}
