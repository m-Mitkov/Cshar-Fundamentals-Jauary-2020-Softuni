using System;
using System.Linq;
using System.Collections.Generic;

namespace appendArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputNumbers = Console.ReadLine()
                 .Split("|")
                 .Reverse()
                 .ToList();

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                List<string> resultList = inputNumbers[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int j = 0; j < resultList.Count; j++)
                {
                    Console.Write($"{resultList[j]} ");
                }
            }

            
        }
    }
}
