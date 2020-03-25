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

            string[] input = Console.ReadLine()
                .Split(" ");

            List<string> validEmails = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (emailExtractor.IsMatch(input[i].ToString()))
                {
                    validEmails.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validEmails));
        }
    }
}
