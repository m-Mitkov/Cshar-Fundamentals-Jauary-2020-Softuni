using System;
using System.Linq;
using System.Collections.Generic;

namespace changeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] comand = Console.ReadLine().Split();

                string toDo = comand[0];

                if (toDo == "end")
                {
                    break;
                }

                else if (toDo == "Delete")
                {
                    int element = int.Parse(comand[1]);
                    input.RemoveAll(x => x == element);
                }

                else
                {
                    int element = int.Parse(comand[1]);
                    int positionWhereToInsert = int.Parse(comand[2]);
                    input.Insert(positionWhereToInsert, element);
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
