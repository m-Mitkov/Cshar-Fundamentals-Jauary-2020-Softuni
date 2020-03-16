using System;
using System.Linq;
using System.Collections.Generic;

namespace characterMultiplier3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                 .Split(" ");

            string firstName = input[0];
            string secondName = input[1];

            int result = 0;

            if (firstName.Length > secondName.Length)
            {
                result = DoMultiplicationOfChar(firstName, secondName);
            }

            else
            {
                result = DoMultiplicationOfChar(secondName, firstName);
            }

            Console.WriteLine(result);
        }

        public static int DoMultiplicationOfChar(string longerName, string secondName)
        {
            int result = 0;

            for (int i = 0; i < longerName.Length; i++)
            {
                if (i < secondName.Length)
                {
                    result += longerName[i] * secondName[i];
                }
                else
                {
                    result += longerName[i];
                }
            }
            return result;
        }
    }
}
