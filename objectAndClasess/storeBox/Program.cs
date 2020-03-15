using System;
using System.Linq;
using System.Collections.Generic;

namespace storeBoxes1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> store = new List<Box>();

            while (input != "end")
            {
                string[] inputArgs = input.Split();

                string serialNumber = inputArgs[0];
                string itemName = inputArgs[1];
                int itemQuantity = int.Parse(inputArgs[2]);
                double itemPrice = double.Parse(inputArgs[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);

                store.Add(box);

                input = Console.ReadLine();
            }

           var result = store.OrderByDescending(x => x.PriceForABox);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"--{item.Item.Name} - ${item.Item.Price:F2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.PriceForABox:F2}");
            }
        }
    }
}
