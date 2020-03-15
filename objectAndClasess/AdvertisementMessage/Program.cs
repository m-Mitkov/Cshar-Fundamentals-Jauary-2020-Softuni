using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] {"Excellent product.", "Such a great product.",
                "I always use that product." ,"Best product of its category.",
                "Exceptional product.", " I can’t live without this product." };

            string[] events = new string[] {"Now i feel good.", "I have succeeded with this product",
            "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] authors = new string[] {"Diana", "Petya", "Stella", "Elena",
            "Katya", "Iva", "Annie", "Eva"};

            string[] cities = new string[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int countOfMessagesToPrint = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfMessagesToPrint; i++)
            {
                Console.WriteLine($"{phrases[Random(phrases)]} {events[Random(events)]}" +
                    $" {authors[Random(authors)]} - {cities[Random(cities)]}");
            }
        }

        public static int Random (string[] input)
        {
            Random random = new Random();
            return random.Next(0, input.Length);
        }
    }
}

