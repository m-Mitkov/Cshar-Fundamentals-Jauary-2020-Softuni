using System;

namespace nXnMatrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            PrintNxNmatrix(inputNumber);
        }

        public static void PrintNxNmatrix(int inputNumber)
        {
            for (int colum = 0; colum < inputNumber; colum++)
            { 
                for (int row = 0; row < inputNumber; row++)
                {
                    Console.Write(inputNumber + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
