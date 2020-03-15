using System;
using System.Linq;

namespace vowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine(CountVowels(input, vowels));
        }

        public static int CountVowels(string input, char[] vowels)
        {
            int countVowels = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    countVowels++;
                }
            }

            return countVowels;
        }
    }
}
