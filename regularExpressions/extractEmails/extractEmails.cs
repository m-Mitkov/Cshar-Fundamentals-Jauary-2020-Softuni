using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace extractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex emailExtractor = new Regex(@"(\s[a-z]+[\w.-]+\w)@([a-z]+[-a-z]*?([.][a-z]+)+)\b");

            string input = Console.ReadLine();

            Console.WriteLine(string.Join(Environment.NewLine,emailExtractor.Matches(input)));
        }
    }
}
