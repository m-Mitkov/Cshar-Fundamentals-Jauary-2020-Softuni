using System;
using System.Linq;
using System.Text;

namespace replaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder formatedText = new StringBuilder();
            formatedText.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                char currentChar = input[i - 1];

                if (currentChar != input[i])
                {
                    formatedText.Append(input[i]);
                }
            }

            Console.WriteLine(formatedText.ToString());
        }
    }
}
