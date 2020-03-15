using System;
using System.Linq;
using System.Collections.Generic;

namespace listOperations2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] comandToDo = Console.ReadLine().Split();

                string toDo = comandToDo[0];

                if (toDo == "End")
                {
                    break;
                }

                if (toDo == "Add")
                {
                    int numberToAdd = int.Parse(comandToDo[1]);

                    inputList.Add(numberToAdd);
                }

                else if (toDo == "Insert")
                {
                    int numberToAdd = int.Parse(comandToDo[1]);
                    int indexWhereToInsert = int.Parse(comandToDo[2]);

                    if (CheckIndexIsValid(inputList, indexWhereToInsert))
                    {
                        inputList.Insert(indexWhereToInsert, numberToAdd);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (toDo == "Remove")
                {
                    int indexToRemove = int.Parse(comandToDo[1]);

                    if (CheckIndexIsValid(inputList, indexToRemove))
                    {
                        inputList.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (toDo == "Shift")
                {
                    string direction = comandToDo[1];
                    int countTimes = int.Parse(comandToDo[2]);

                    DoShiftComand(inputList, direction, countTimes);
                }
            }

            Console.WriteLine(string.Join(" ", inputList));
        }

        public static bool CheckIndexIsValid(List<int> input, int index)
        {
            if (index >= 0 && index <= input.Count - 1)
            {
                return true;
            }

            return false;
        }

        public static void DoShiftComand(List<int> input, string direction, int countTimes)
        {
            if (direction == "left")
            {
                for (int i = 0; i < countTimes; i++)
                {
                    int firstNum = input[0];

                    input.Add(firstNum);

                    input.RemoveAt(0);
                }
            }

            else
            {
                for (int i = 0; i < countTimes; i++)
                {
                    int lastNum = input[input.Count - 1];

                    input.Insert(0, lastNum);

                    input.RemoveAt(input.Count - 1);
                }
            }
        }
    }
}
