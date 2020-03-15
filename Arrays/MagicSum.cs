using System;
using System.Linq;

namespace magicSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputArray.Length; i++)
            {
                int currentNum = inputArray[i];

                for (int k = i + 1; k < inputArray.Length; k++)
                {
                    if (currentNum + inputArray[k] == magicSum)
                    {
                        Console.WriteLine(currentNum + " " + inputArray[k]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
