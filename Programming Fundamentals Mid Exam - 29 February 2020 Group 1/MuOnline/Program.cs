using System;
using System.Linq;
using System.Collections.Generic;

namespace muOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int healt = 100;
            int bitcoins = 0;

            string[] input = Console.ReadLine().Split("|");

            for (int i = 0; i < input.Length; i++)
            {
                string currentRoom = input[i];

                string[] currentRoomArgs = currentRoom.Split(" ");

                string comand = currentRoomArgs[0];

                if (comand == "potion")
                {
                    int bonusHealt = int.Parse(currentRoomArgs[1]);

                    if (bonusHealt + healt > 100)
                    {
                        int toHeal = 100 - healt;
                        Console.WriteLine($"You heald for {toHeal} hp.");

                        healt = 100;

                        Console.WriteLine($"Current health: {healt} hp.");
                    }

                    else
                    {
                        Console.WriteLine($"You heald for {bonusHealt} hp.");

                        healt += bonusHealt;

                        Console.WriteLine($"Current health: {healt} hp.");
                    }
                }

                else if (comand == "chest")
                {
                    int bitcoinsFound = int.Parse(currentRoomArgs[1]);

                    bitcoins += bitcoinsFound;

                    Console.WriteLine($"You found {bitcoinsFound} bitcoins.");
                }

                else
                {
                    string monster = comand;
                    int attackOfMonster = int.Parse(currentRoomArgs[1]);

                    if (healt - attackOfMonster > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                        healt -= attackOfMonster;
                    }

                    else if (healt - attackOfMonster <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {healt}");
        }
    }
}
