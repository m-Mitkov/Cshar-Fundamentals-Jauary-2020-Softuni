using System;
using System.Linq;
using System.Collections.Generic;

namespace tankCollector1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ownedTanks = Console.ReadLine()
                .Split(", ").ToList();

            int numberOfComandToFollow = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfComandToFollow; i++)
            {
                string[] comand = Console.ReadLine()
                    .Split(", ")
                    .ToArray();

                string toDo = comand[0];

                if (toDo.StartsWith("Add"))
                {
                    string tankName = comand[1];

                    if (ownedTanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        Console.WriteLine("Tank successfully bought");
                        ownedTanks.Add(tankName);
                    }
                }

                else if (toDo.StartsWith("Remove At"))
                {
                    int indexWhereToRemove = int.Parse(comand[1]);

                    if (CheckIfIndexIsValid(ownedTanks, indexWhereToRemove))
                    {
                        Console.WriteLine("Tank successfully sold");
                        ownedTanks.RemoveAt(indexWhereToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }

                else if (toDo.StartsWith("Remove"))
                {
                    string tankToSell = comand[1];

                    if (ownedTanks.Contains(tankToSell))
                    {
                        Console.WriteLine("Tank successfully sold");
                        ownedTanks.Remove(tankToSell);
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }


                else if (toDo.StartsWith("Insert"))
                {
                    int indexWhereToInsert = int.Parse(comand[1]);
                    string tankName = comand[2];

                    if (CheckIfIndexIsValid(ownedTanks, indexWhereToInsert) && ownedTanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else if (CheckIfIndexIsValid(ownedTanks, indexWhereToInsert) == false)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    else if (CheckIfIndexIsValid(ownedTanks, indexWhereToInsert) && !ownedTanks.Contains(tankName))
                    {
                        Console.WriteLine("Tank successfully bought");
                        ownedTanks.Insert(indexWhereToInsert, tankName);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", ownedTanks));
        }

        static bool CheckIfIndexIsValid(List<string> tanks, int index)
        {
            if (index < 0 || index > tanks.Count)
            {
                return false;
            }
            return true;
        }
    }
}
