using System;
using System.Collections.Generic;
using System.Linq;

namespace studentAcademy1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentDatabase = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfComands; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentDatabase.ContainsKey(student))
                {
                    studentDatabase.Add(student, new List<double>());

                    studentDatabase[student].Add(grade);
                }
                else
                {
                    studentDatabase[student].Add(grade);
                }
            }

            studentDatabase = studentDatabase
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine(string.Join(Environment.NewLine, studentDatabase
                .Select(x => $"{x.Key} -> {x.Value.Average():F2}")));
        }
    }
}
