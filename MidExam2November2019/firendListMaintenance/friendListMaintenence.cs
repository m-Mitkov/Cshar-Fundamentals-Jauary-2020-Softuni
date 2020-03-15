using System;
using System.Linq;
using System.Collections.Generic;

namespace friendListMaintenence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friendsList = Console.ReadLine()
                 .Split(", ").ToList();

            int countBlacklist = 0;
            int countLost = 0;

            while (true)
            {
                string comand = Console.ReadLine();

                if (comand == "Report")
                {
                    break;
                }

                string[] comandArgs = comand.Split(" ");

                string toDo = comandArgs[0];

                switch (toDo)
                {
                    case "Blacklist":
                        string nameToBlackList = comandArgs[1];

                        if (friendsList.Any(x => x == nameToBlackList))
                        {
                            int indexToBlackList = friendsList.IndexOf(nameToBlackList);
                            friendsList[indexToBlackList] = "Blacklisted";
                            Console.WriteLine($"{nameToBlackList} was blacklisted.");
                        }
                        else
                        {
                            Console.WriteLine($"{nameToBlackList} was not found.");
                        }
                        break;

                    case "Error":
                        int indexToCheck = int.Parse(comandArgs[1]);

                        if (friendsList[indexToCheck] != "Blacklisted" &&
                            friendsList[indexToCheck] != "Lost")
                        {
                            Console.WriteLine($"{friendsList[indexToCheck]} was lost due to an error.");
                            friendsList[indexToCheck] = "Lost";
                        }
                        break;

                    case "Change":
                        int indexToChange = int.Parse(comandArgs[1]);
                        string newName = comandArgs[2];

                        if (CheckIfIndexIsValid(friendsList, indexToChange))
                        {
                            Console.WriteLine($"{friendsList[indexToChange]} changed his " +
                                $"username to {newName}.");

                            friendsList[indexToChange] = newName;
                        }
                        break;
                }
            }

            Console.WriteLine($"Blacklisted names: {friendsList.Count(x => x == "Blacklisted")} ");
            Console.WriteLine($"Lost names: {friendsList.Count(x => x == "Lost")} ");
            Console.WriteLine(string.Join(" ", friendsList));

        }
        public static bool CheckIfIndexIsValid (List<string> friends, int index)
        {
            if (index < 0 || index > friends.Count)
            {
                return false;
            }
            return true;
        }          
    }
}
