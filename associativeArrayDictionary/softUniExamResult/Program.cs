using System;
using System.Linq;
using System.Collections.Generic;

namespace softUniExamResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> resultPoints = new Dictionary<string, List<int>>();
            Dictionary<string, int> countSubmission = new Dictionary<string, int>();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }
                string[] inputArgs = input.Split("-");

                if (inputArgs.Length == 2)
                {
                    string usernameToBan = inputArgs[0];

                    resultPoints.Remove(usernameToBan);
                    continue;
                }

                string username = inputArgs[0];
                string language = inputArgs[1];
                int points = int.Parse(inputArgs[2]);

                if (!resultPoints.ContainsKey(username))
                {
                    resultPoints.Add(username, new List<int>());

                    resultPoints[username].Add(points);
                }

                else
                {
                    resultPoints[username].Add(points);
                }

                if (!countSubmission.ContainsKey(language))
                {
                    countSubmission[language] = 0;
                }

                countSubmission[language]++;


            }

            resultPoints = resultPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            countSubmission = countSubmission
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Results:");

            foreach (var nrp in resultPoints)   //nrp => name result pair
            {
                Console.WriteLine($"{nrp.Key} | {nrp.Value.Max()}");
            }

            foreach (var lsp in countSubmission)    //language submission pair
            {
                Console.WriteLine($"{lsp.Key} - {lsp.Value}");
            }
        }
    }
}
