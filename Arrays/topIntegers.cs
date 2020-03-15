using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            string result = string.Empty;

            for (int i = 0; i < inputArray.Length; i++)
            {
                var currentNumber = inputArray[i];
                bool isTopInteger = true;

                for (int k = i + 1; k < inputArray.Length; k++)
                {
                    if (currentNumber <= inputArray[k])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    result += currentNumber + " ";
                }
            }
            Console.Write(result);
        }
    }
}
