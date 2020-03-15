using System;
using System.Collections.Generic;
using System.Linq;

namespace randomizeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
            .Split(" ")
            .ToList();

            Random random = new Random();

            for (int i = 0; i < input.Count; i++)
            {
                int randomIndex = random.Next(0, input.Count);

                string currentWord = input[i];
                string randomElement = input[randomIndex];

                input[i] = randomElement;
                input[randomIndex] = currentWord;
            }

            Console.Write(string.Join(Environment.NewLine, input));
        }
    }
}
