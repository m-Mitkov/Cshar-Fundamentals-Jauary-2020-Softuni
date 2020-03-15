using System;
using System.Linq;
using System.Collections.Generic;

namespace courses1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ");

                if (input[0] == "end")
                {
                    break;
                }

                string course = input[0];
                string student = input[1];

                if (!database.ContainsKey(course))
                {
                    database[course] = new List<string>();
                    database[course].Add(student);

                    database[course] = database[course]
                        .OrderBy(x => x)
                        .ToList();
                }
                else
                {
                    database[course].Add(student);

                    database[course] = database[course]
                        .OrderBy(x => x)
                        .ToList();
                }
            }

            database = database.OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in database)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine($"-- {kvp.Value[i]}");
                }
            }
        }
    }
}
