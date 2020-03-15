using System;
using System.Collections.Generic;
using System.Linq;

namespace topNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            CheckSumDigitsDivisibleByEight(inputNumber);
        }
        public static void CheckSumDigitsDivisibleByEight(int inputNumber)
        {
            List<int> filtredNumbers = new List<int>();

            for (int i = 0; i <= inputNumber; i++)
            {
                bool atLeastOneOddDigit = false;

                int digitsSum = 0;
                int currentNumToCheck = i;

                while (currentNumToCheck > 0)
                {
                    int digitToAdd = currentNumToCheck % 10;

                    if (digitToAdd % 2 == 1)
                    {
                        atLeastOneOddDigit = true;
                    }

                    digitsSum += digitToAdd;

                    currentNumToCheck /= 10;
                }

                if (digitsSum % 8 == 0 && atLeastOneOddDigit)
                {
                    filtredNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, filtredNumbers));
            return;
        }
    }
}
