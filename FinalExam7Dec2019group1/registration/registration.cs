using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternForRegistration = new Regex(@"(U\$)([A-Z][a-z]{2,})\1(P\@\$)([A-Za-z]{5,}[0-9]+)\3");

            int numberOfInputs = int.Parse(Console.ReadLine());

            int countSuccessfullRegistrations = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                if (patternForRegistration.IsMatch(input))
                {
                    countSuccessfullRegistrations++;

                    Console.WriteLine("Registration was successful");

                    string username = patternForRegistration.Match(input).Groups[2].ToString();
                    string password = patternForRegistration.Match(input).Groups[4].ToString();

                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
                else
                    {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {countSuccessfullRegistrations}");
        }
    }
}
