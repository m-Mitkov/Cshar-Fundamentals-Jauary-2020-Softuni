using System;
using System.Linq;

namespace ZigZagArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            int[] firstArr = new int[numberOfInputs];
            int[] secondArr = new int[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++)
            {
                int[] inputNumbers = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = inputNumbers[0];
                    secondArr[i] = inputNumbers[1];
                }
                else
                {
                    firstArr[i] = inputNumbers[1];
                    secondArr[i] = inputNumbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
