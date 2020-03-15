using System;
using System.Linq;
using System.Collections.Generic;

namespace countCharInAstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < inputWord.Length; i++)
            {
                char currentChar = inputWord[i];

                if (currentChar == ' ')
                {
                    continue;
                }
                if (!dictionary.ContainsKey(currentChar))
                {
                    dictionary[currentChar] = 1;
                }
                else
                {
                    dictionary[currentChar]++;
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
