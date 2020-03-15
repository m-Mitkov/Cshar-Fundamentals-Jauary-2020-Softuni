using System;
using System.Linq;
using System.Collections.Generic;

namespace addAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());

            int sumResult = Sum(firstNum, secondNum);
            int resultSubtraction = Subtract(sumResult, thirdNum);

            Console.WriteLine(resultSubtraction);
        }

        public static int Sum (int firsNum, int secondNum)
        {
            int result = firsNum + secondNum;
            return result;
        }

        public static int Subtract(int result, int thirdNum)
        {
            int resultSubtraction = result - thirdNum;
            return resultSubtraction;
        }
    }
}
