using System;
using System.Linq;
using System.Collections.Generic;

namespace experienceGaining1
{
    class Program
    {
        static void Main(string[] args)
        {
            int experienceNeeded = int.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());

            double totalExperienceGained = 0;

            for (int i = 1; i <= countOfBattles; i++)
            {
                int experienceGainedPerGame = int.Parse(Console.ReadLine());
                totalExperienceGained += experienceGainedPerGame;

                if (i % 3 == 0)
                {
                    double extraExperience = experienceGainedPerGame * 0.15;

                    totalExperienceGained += extraExperience;
                }

                else if (i % 5 == 0)
                {
                    double lessExperience = experienceGainedPerGame * 0.10;

                    totalExperienceGained -= lessExperience;
                }

                if (totalExperienceGained >= experienceNeeded)
                {
                    Console.WriteLine($"Player succesfully collected his needed experience " +
                        $"for {i} battles.");
                    return;
                }
            }
            double neededExperinceMore = experienceNeeded - totalExperienceGained;

            Console.WriteLine($"Player was not able to collect the needed experience, " +
                $"{neededExperinceMore} more needed.");
        }
    }
}
