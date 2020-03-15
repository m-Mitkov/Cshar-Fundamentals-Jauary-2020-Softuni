using System;
using System.Collections.Generic;
using System.Linq;

namespace softuniParking1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());

            Dictionary<string, string> nameAndLicensePlate = new Dictionary<string, string>();

            for (int i = 0; i < numberOfComands; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string toDo = input[0];
                string username = input[1];

                if (toDo == "register")
                {
                    string licensePlate = input[2];

                    if (!nameAndLicensePlate.ContainsKey(username))
                    {
                        nameAndLicensePlate.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number " +
                            $"{nameAndLicensePlate[username]}");
                    }
                }

                else if (toDo == "unregister")
                {
                    if (nameAndLicensePlate.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        nameAndLicensePlate.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var kvp in nameAndLicensePlate)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
