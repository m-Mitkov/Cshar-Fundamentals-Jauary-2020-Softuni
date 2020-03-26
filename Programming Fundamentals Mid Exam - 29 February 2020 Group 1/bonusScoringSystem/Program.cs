using System;
using System.Linq;
using System.Collections.Generic;

namespace bonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = double.MinValue;
            int maxAttendanceLectures = 0;

            for (int i = 0; i < countOfStudents; i++)
            {
                int currentStudentAttendance = int.Parse(Console.ReadLine());

                double currentMaxBonus = ((double)currentStudentAttendance / (double)countOfLectures) * (5 + initialBonus);

                if (currentMaxBonus > maxBonus)
                {
                    maxBonus = currentMaxBonus;
                    maxAttendanceLectures = currentStudentAttendance;
                    currentMaxBonus = 0;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}");
            Console.WriteLine($"The student has attended {maxAttendanceLectures}");
        }
    }
}
