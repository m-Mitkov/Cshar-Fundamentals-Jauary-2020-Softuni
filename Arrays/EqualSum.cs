using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int sumInputNumbers = inputNumbers.Sum();
            int sumCurrentNumbers = 0;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int currentNum = inputNumbers[i];

                sumInputNumbers -= currentNum;

                if (sumInputNumbers == sumCurrentNumbers)
                {
                    Console.WriteLine(i);
                    return;
                }

                sumCurrentNumbers += currentNum;
            }
            
                Console.WriteLine("no");
        }
    }
}
