using System;
using System.Linq;

namespace middleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string middleChar = GetMiddleCharacter(input);

            Console.WriteLine(middleChar.ToString());
        }

        static public string GetMiddleCharacter(string input)
        {
            string middleChar = string.Empty;

            if (input.Length % 2 == 1)
            {
                middleChar = input[(input.Length / 2)].ToString();
            }

            else
            {
                middleChar = input[(input.Length / 2) - 1].ToString();
                middleChar += input[input.Length / 2];
            }

            return middleChar.ToString();
        }
    }
}
