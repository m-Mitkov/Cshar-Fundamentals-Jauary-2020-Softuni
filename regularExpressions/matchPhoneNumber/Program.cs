using System;
using System.Text.RegularExpressions;

namespace matchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patern = new Regex(@"\+359( |-)\d\1\d{3}\1\d{4}\b");

            MatchCollection matches = patern.Matches(Console.ReadLine());

            foreach (Match match in matches)
            {
                Console.Write(match.Value + ", ",StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
