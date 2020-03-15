using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int numberOfRotationsToDo = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfRotationsToDo; i++)
            {
                int temporary = inputArray[0];

                for (int k = 0; k < inputArray.Length - 1; k++)
                {
                    inputArray[k] = inputArray[k + 1];
                }

                inputArray[inputArray.Length - 1] = temporary;
            }

            Console.WriteLine(string.Join(" ", inputArray));
        }
    }
}
