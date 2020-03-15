using System;
using System.Numerics;

namespace bigFactorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToCalculateFactorial = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 1; i <= numberToCalculateFactorial; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
