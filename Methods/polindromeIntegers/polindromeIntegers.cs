using System;
using System.Linq;

namespace polindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                CheckIfIsPolindromeNum(input);
            }
        }

        public static void CheckIfIsPolindromeNum(string inputNumber)
        {
            for (int i = 0; i < inputNumber.Length / 2; i++)
            {
                if (inputNumber[i] != inputNumber[inputNumber.Length - i - 1])
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            Console.WriteLine("true");
            return;
        }
    }
}
