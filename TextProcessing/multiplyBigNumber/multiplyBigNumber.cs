using System;
using System.Collections.Generic;

namespace multiplyBigNumber1
{
    class Program
    { // The task was not to use the build in BigInteger Class.
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            bigNumber = bigNumber.TrimStart(new char[] { '0'});
            int multiplier = int.Parse(Console.ReadLine());

            int onMind = 0;
            List<int> result = new List<int>();

            if (multiplier == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                string currentDigitAsString = bigNumber[i].ToString();
                int currentDigit = int.Parse(currentDigitAsString);

                int multiplication = currentDigit * multiplier;

                if (onMind != 0)
                {
                    multiplication += onMind;
                    onMind = 0;
                }
                if (multiplication > 9)
                {
                    result.Insert(0, multiplication % 10);

                    onMind = multiplication / 10;
                }

                else
                {
                    result.Insert(0, multiplication);
                }
            }

            if (onMind != 0)
            {
                result.Insert(0, onMind);
            }

            if (result.Count == 0)
            {
                Console.WriteLine("0");
                return;
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
