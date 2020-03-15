using System;
using System.Collections.Generic;
using System.Linq;

namespace smallestOfThreeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> threeNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                threeNumbers.Add(inputNumber);
            }

            int result = GetSmallestNum(threeNumbers);

            Console.WriteLine(result);
        }

        public static int GetSmallestNum(List<int> threeNumbers)
        {
            int smallestNum = threeNumbers[0];

            for (int i = 1; i < threeNumbers.Count; i++)
            {
                if (threeNumbers[i] < smallestNum)
                {
                    smallestNum = threeNumbers[i];
                }
            }

            return smallestNum;
        }
    }
}
