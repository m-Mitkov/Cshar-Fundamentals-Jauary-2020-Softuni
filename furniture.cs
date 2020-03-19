using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^>>(\w+)<<(\d+(\.\d +)?)!(\d+)\b");
            // Group 1 - furniture type   Group 2 - price  Group 3 - decimal separator   Group 4 - quantity

            List<string> purchasedProducts = new List<string>();
            decimal totoalMoneySpend = 0;

            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                if (pattern.IsMatch(input))
            {
                int quantity = int.Parse(pattern.Match(input).Groups[4].ToString());

                if (quantity > 0)
                {
                    string furnitureType = pattern.Match(input).Groups[1].ToString();

                    purchasedProducts.Add(furnitureType);

                    decimal price = decimal.Parse(pattern.Match(input).Groups[2].ToString());

                    totoalMoneySpend += price * quantity;
                }
            }
            input = Console.ReadLine();
        }
        Console.WriteLine("Bought furniture:");
            if (purchasedProducts.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, purchasedProducts));
            }

    Console.WriteLine($"Total money spend: {totoalMoneySpend:F2}");

        }
    }
}
