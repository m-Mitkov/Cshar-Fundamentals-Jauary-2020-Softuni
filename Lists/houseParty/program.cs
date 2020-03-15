using System;
using System.Linq;
using System.Collections.Generic;

namespace houseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfComands; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];

                if (input.Contains("not"))
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

                else
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }

            Console.Write(string.Join(Environment.NewLine, guests));
        }
    }
}
