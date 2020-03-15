using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfWagonswagons = int.Parse(Console.ReadLine());

            int[] train = new int[NumberOfWagonswagons];

            for (int i = 0; i < NumberOfWagonswagons; i++)
            {
                int numberOfPeopleInWagon = int.Parse(Console.ReadLine());

                train[i] = numberOfPeopleInWagon;
            }

            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(train.Sum());
        }
    }
}
