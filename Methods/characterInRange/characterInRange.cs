using System;
using System.Linq;
using System.Collections.Generic;

namespace charactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharInBetween(firstChar, secondChar);
        }

        static void PrintCharInBetween(char firstChar, char secondChar)
        {
            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar, secondChar);

            for (int i = startChar + 1; i < endChar; i++)
            {
                string currentChar = i.ToString();
                Console.Write((char)i + " ");
            }
        }
    }
}
