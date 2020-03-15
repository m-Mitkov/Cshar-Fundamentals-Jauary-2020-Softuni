using System;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split()
                 .Select(int.Parse).ToArray();

            int bestLenghtSequence = 1;
            string elementBestSequence = string.Empty;

            int currentLenghtSequence = 1;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int currentElement = inputArray[i];

                if (currentElement == inputArray[i + 1])
                {
                    currentLenghtSequence++;
                }
               
                if (currentLenghtSequence > bestLenghtSequence)
                {
                    bestLenghtSequence = currentLenghtSequence;
                    elementBestSequence = currentElement.ToString();
                }

                if (currentElement != inputArray[i + 1])
                {
                    currentLenghtSequence = 1;
                }
            }

            for (int i = 0; i < bestLenghtSequence; i++)
            {
                Console.Write(elementBestSequence + " ");
            }
        }
    }
}
