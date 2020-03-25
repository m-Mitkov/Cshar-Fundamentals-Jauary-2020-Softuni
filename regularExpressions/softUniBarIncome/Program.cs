using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace softUniBarIncome1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternName = new Regex(@"\%([A-Z][a-z]+)\%");
            Regex pattetnProduct = new Regex(@"<(\w+)>");
            Regex patternQuantity = new Regex(@"\|(\d+)\|");
            Regex patternPrice = new Regex(@"(\d+(\.?\d+)?)\$");

            decimal totalIncome = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }

                decimal currentBill = 0;

                if (patternName.IsMatch(input) && pattetnProduct.IsMatch(input) &&
                    patternQuantity.IsMatch(input) && patternPrice.IsMatch(input))

                {
                    string customer = patternName.Match(input).Groups[1].ToString();
                    string product = pattetnProduct.Match(input).Groups[1].ToString();
                    int quantity = int.Parse(patternQuantity.Match(input).Groups[1].ToString());
                    decimal price = decimal.Parse(patternPrice.Match(input).Groups[1].ToString());

                    currentBill = quantity * price;

                    Console.WriteLine($"{customer}: {product} - {currentBill:F2}");
                }

                totalIncome += currentBill;
            }

            Console.WriteLine($"Total income: {totalIncome}");
        }
    }
}
