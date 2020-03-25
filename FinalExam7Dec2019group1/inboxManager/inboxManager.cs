using System;
using System.Linq;
using System.Collections.Generic;

namespace inboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> databaseEmails = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] comand = Console.ReadLine().Split("->");

                if (comand[0] == "Statistics")
                {
                    break;
                }

                string toDo = comand[0];
                string username = comand[1];

                if (toDo == "Add")
                {
                    if (!databaseEmails.ContainsKey(username))
                    {
                        databaseEmails.Add(username, new List<string>());
                        continue;
                    }
                    Console.WriteLine($"{username} is already registered");
                }

                else if (toDo == "Send")
                {
                    string email = comand[2];

                    if (databaseEmails.ContainsKey(username))
                    {
                        databaseEmails[username].Add(email);
                    }
                }

                else if (toDo == "Delete")
                {
                    if (databaseEmails.ContainsKey(username))
                    {
                        databaseEmails.Remove(username);
                        continue;
                    }
                    Console.WriteLine($"{username} not found!");
                }
            }

            Console.WriteLine($"Users count: {databaseEmails.Keys.Count}");

            databaseEmails = databaseEmails
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var user in databaseEmails)
            {
                Console.WriteLine(user.Key);

                for (int i = 0; i < user.Value.Count; i++)
                {
                    Console.WriteLine($"- {user.Value[i]}");
                }
            }
        }
    }
}
