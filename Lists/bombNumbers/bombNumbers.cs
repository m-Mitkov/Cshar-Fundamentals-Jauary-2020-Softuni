using System;
using System.Collections.Generic;
using System.Linq;

namespace bombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialNumber = bombNumber[0];
            int powerSpecialNumber = bombNumber[1];

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == specialNumber)
                {
                    int startBomb = i - powerSpecialNumber;

                    if (startBomb < 0)
                    {
                        startBomb = 0;
                    }

                    int endBomb = i + powerSpecialNumber + 1;

                    if (endBomb > inputList.Count)
                    {
                        endBomb = inputList.Count;
                    }

                    for (int j = startBomb; j < endBomb; j++)
                    {
                        inputList.RemoveAt(startBomb);
                    }
                    i--;
                }
            }

            Console.WriteLine(inputList.Sum());
        }
    }
}
