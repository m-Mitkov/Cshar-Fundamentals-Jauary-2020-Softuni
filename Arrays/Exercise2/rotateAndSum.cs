using System;
using System.Linq;
using System.Collections.Generic;

namespace rotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                 .Split()
                 .Select(x => int.Parse(x))
                 .ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());

            inputArr = Rotate(inputArr, numberOfRotations);

            Console.WriteLine(string.Join(" ", inputArr));
        }
        public static int[] Rotate(int[] inputArr, int rotations)
        {

            if (inputArr.Length <= 1)
            {
                return inputArr;
            }

            int[] sumArr = new int[inputArr.Length];

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = inputArr[inputArr.Length - 1];

                int[] newArr = new int[inputArr.Length];
                newArr[0] = lastElement;

                for (int k = 1; k < inputArr.Length; k++)
                {
                    newArr[k] = inputArr[k - 1];
                }

                for (int j = 0; j < sumArr.Length; j++)
                {
                    sumArr[j] += newArr[j];
                }

                inputArr = newArr;
            }

            return sumArr;
        }
    }
}
