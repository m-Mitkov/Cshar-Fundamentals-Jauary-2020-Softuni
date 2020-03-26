using System;
using System.Linq;
using System.Collections.Generic;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(" - ");

                if (comand[0] == "Craft!")
                {
                    break;
                }

                string toDo = comand[0];

                if (toDo == "Collect")
                {
                    string itemToAdd = comand[1];

                    if (!inventory.Contains(itemToAdd))
                    {
                        inventory.Add(itemToAdd);
                    }
                }

                else if (toDo == "Drop")
                {
                    string itemToDrop = comand[1];

                    if (inventory.Contains(itemToDrop))
                    {
                        inventory.Remove(itemToDrop);
                    }
                }

                else if (toDo == "Combine Items")
                {
                    string[] items = comand[1].Split(":");

                    string oldItem = items[0];
                    string newItem = items[1];

                    if (inventory.Contains(oldItem))
                    {
                        int indexOldItem = inventory.IndexOf(oldItem);
                        inventory.Insert(indexOldItem + 1, newItem);
                    }
                }

                else if (toDo == "Renew")
                {
                    string itemToRenew = comand[1];

                    if (inventory.Contains(itemToRenew))
                    {
                        inventory.Remove(itemToRenew);
                        inventory.Add(itemToRenew);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
