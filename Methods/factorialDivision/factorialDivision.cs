using System;

namespace factorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());

            double factorialFirstNum = GetFactorial(firstInput);
            double factorialSecondNum = GetFactorial(secondInput);

            Division(factorialFirstNum, factorialSecondNum);
        }

        public static double GetFactorial(int number)
        {
            double factorial = number;
            for (int i = number - 1; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static void Division(double firstNumFactorial, double secondNumFactorial)
        {
            double result = firstNumFactorial / secondNumFactorial;

            Console.WriteLine($"{result:F2}");
        }
    }
}
