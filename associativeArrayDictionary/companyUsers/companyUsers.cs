using System;
using System.Linq;
using System.Collections.Generic;

namespace companyUsers1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesDatabase = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                if (input[0] == "End")
                {
                    break;
                }

                string comapany = input[0];
                string employeeID = input[1];

                if (!companiesDatabase.ContainsKey(comapany))
                {
                    companiesDatabase.Add(comapany, new List<string>());

                    companiesDatabase[comapany].Add(employeeID);
                }

                else if (companiesDatabase.ContainsKey(comapany))
                {
                    if (companiesDatabase[comapany].Contains(employeeID))
                    {
                        continue;
                    }
                    else
                    {
                        companiesDatabase[comapany].Add(employeeID);
                    }
                }
            }

            companiesDatabase = companiesDatabase.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in companiesDatabase)
            {
                Console.WriteLine($"{kvp.Key}");

                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    Console.WriteLine("-- " + string.Join("", kvp.Value[i]));
                }
            }
        }
    }
}
