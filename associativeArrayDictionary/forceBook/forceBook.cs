using System;
using System.Linq;
using System.Collections.Generic;

namespace forceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains("|"))
                {
                    string[] inputArgs = input.Split(" | ");

                    string side = inputArgs[0];
                    string user = inputArgs[1];

                    if (!database.ContainsKey(side))
                    {
                        database.Add(side, new List<string>());

                        if (!database.Values.Any(x => x.Contains(user)))
                        {
                            database[side].Add(user);
                        }
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] inputArgs = input.Split(" -> ");

                    string user = inputArgs[0];
                    string side = inputArgs[1];

                    foreach (var kvp in database)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            kvp.Value.Remove(user);
                        }
                    }
                        if (!database.ContainsKey(side))
                        {
                            database[side] = new List<string>();
                        }

                        database[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");

                }
            }


            database = database.Where(x => x.Value.Count > 0)
                  .OrderByDescending(x => x.Value.Count)
                  .ThenBy(x => x.Key)
                  .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in database)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                kvp.Value.Sort();

                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"! {kvp.Value[i]}");
                }
            }
        }
    }
}
