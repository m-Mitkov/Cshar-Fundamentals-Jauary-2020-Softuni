using System;
using System.Linq;

namespace foldAndSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            int[] firstArrToFold = new int[inputArr.Length / 2];

            int leftStartIndex = inputArr.Length / 4 - 1;
            int rightIndex = 3 * inputArr.Length / 4;

            int numbersSoFar = 0;

            for (int i = leftStartIndex; i >= 0; i--)
            {
                numbersSoFar++;
                firstArrToFold[leftStartIndex - i] = inputArr[i];
            }

            for (int i = inputArr.Length - 1; i >= rightIndex; i--)
            {
                firstArrToFold[inputArr.Length - 1 - i + numbersSoFar] = inputArr[i];
            }

            int[] secondArrToFold = new int[inputArr.Length / 2];

            for (int i = leftStartIndex + 1; i < rightIndex; i++)
            {
                secondArrToFold[i - numbersSoFar] = inputArr[i];
            }

            for (int i = 0; i < secondArrToFold.Length; i++)
            {
                Console.Write(firstArrToFold[i] + secondArrToFold[i] + " ");
            }
        }
    }
}
