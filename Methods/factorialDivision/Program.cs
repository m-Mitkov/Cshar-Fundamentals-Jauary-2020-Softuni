using System;

namespace factorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());

            int factorialFirstNum = GetFactorial(firstInput);
            int factorialSecondNum = GetFactorial(secondInput);

            Division(factorialFirstNum, factorialSecondNum);
        }

        public static int GetFactorial(int number)
        {
            int factorial = number;
            for (int i = number - 1; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static void Division(int firstNumFactorial, int secondNumFactorial)
        {
            double result = firstNumFactorial / secondNumFactorial;

            Console.WriteLine($"{result:F2}");
        }
    }
}
