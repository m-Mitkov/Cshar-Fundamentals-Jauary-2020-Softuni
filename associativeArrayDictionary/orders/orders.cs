using System;
using System.Linq;
using System.Collections.Generic;

namespace orders1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productAndQuantity = new Dictionary<string, int>();
            Dictionary<string, double> productAndPrice = new Dictionary<string, double>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");

                if (input[0] == "buy")
                {
                    break;
                }

                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                if (!productAndPrice.ContainsKey(product))
                {
                    productAndPrice[product] = price;
                    productAndQuantity[product] = quantity;
                }

                else
                {
                    productAndPrice[product] = price;
                    productAndQuantity[product] += quantity;
                }
            }

            foreach (var kvp in productAndQuantity)
            {
                string product = kvp.Key;
                int quantity = kvp.Value;

                foreach (var price in productAndPrice)
                {
                    double priceItem = price.Value;

                    if (product == price.Key)
                    {
                        double totalPrice = quantity * priceItem;

                        Console.WriteLine($"{product} -> {totalPrice:F2}");
                    }
                }
            }
        }
    }
}
