using System;
using System.Text.RegularExpressions;

namespace matchFullName1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";

            string input = Console.ReadLine();

            MatchCollection validNames = Regex.Matches(input, pattern);

            foreach (Match name in validNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
