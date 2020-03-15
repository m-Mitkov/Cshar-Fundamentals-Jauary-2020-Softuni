using System;
using System.Linq;
using System.Collections.Generic;

namespace train2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            int maxCapacityWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string comand = Console.ReadLine();

                string[] comandArgs = comand.Split();

                if (comand == "end")
                {
                    break;
                }

                else if (comandArgs[0] == "Add")
                {
                    int wagonWithPassengerdToAdd = int.Parse(comandArgs[1]);
                    train.Add(wagonWithPassengerdToAdd);
                }

                else
                {
                    int passengersToAdd = int.Parse(comandArgs[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + passengersToAdd <= maxCapacityWagon)
                        {
                            train[i] += passengersToAdd;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
