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
                //if (i < 10)
                //{
                //    if (i % 8 == 0)
                //    {
                //        if (i % 2 != 0)
                //        {
                //            filtredNumbers.Add(i);
                //        }
                //    }
                //}

                //if
                //{
                    int digitsSum = 0;
                    int currentNumToCheck = i;

                    while (currentNumToCheck > 0)
                    {
                        int digitToAdd = currentNumToCheck % 10;

                        if (digitToAdd % 2 == 1)
                        {
                            atLeastOneOddDigit = true;
                        }

                        digitsSum = digitsSum + digitToAdd;

                        currentNumToCheck = currentNumToCheck / 10;
                    }

                    if (digitsSum % 8 == 0 && atLeastOneOddDigit)
                    {
                        filtredNumbers.Add(i);
                    }
                }
            //}

            Console.WriteLine(string.Join(Environment.NewLine, filtredNumbers));
            return;
        }
    }
}
