using System;
using System.Linq;
using System.Collections.Generic;

namespace minerTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (true)
            {
                string material = Console.ReadLine();

                if (material == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(material))
                {
                    resources[material] = quantity;
                }
                else
                {
                    resources[material] += quantity;
                }
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
