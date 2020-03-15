using System;
using System.Collections.Generic;
using System.Linq;

namespace arrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();

            string comand = string.Empty;

            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comandArgs = comand.Split();

                string toDo = comandArgs[0];

                if (toDo == "exchange")
                {
                    int indexWhereToSplit = int.Parse(comandArgs[1]);

                    DoExchangeComand(inputArray, indexWhereToSplit);
                }

                else if (toDo == "max")
                {
                    string evenOrOdd = comandArgs[1];

                    FindMaxEvenOrOddElement(inputArray, evenOrOdd);
                }

                else if (toDo == "min")
                {
                    string evenOrOdd = comandArgs[1];

                    FindMinEvenOrOddElement(inputArray, evenOrOdd);
                }

                else if (toDo == "first")
                {
                    int count = int.Parse(comandArgs[1]);
                    string evenOrOdd = comandArgs[2];

                    ReturnFirstCountElements(inputArray, count, evenOrOdd);
                }

                else if (toDo == "last")
                {
                    int count = int.Parse(comandArgs[1]);
                    string evenOrOdd = comandArgs[2];

                    ReturnLastCountElements(inputArray, count, evenOrOdd);
                }
            }

            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        public static void DoExchangeComand(int[] inputArray, int indexWhereToSplit)
        {
            List<int> temporary = new List<int>();

            if (indexWhereToSplit < 0 || indexWhereToSplit > inputArray.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            for (int i = 0; i <= indexWhereToSplit; i++)
            {
                int firstNum = inputArray[0];

                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }

                inputArray[inputArray.Length - 1] = firstNum;
            }
        }

        public static void FindMaxEvenOrOddElement(int[] inputArray, string evenOrOdd)
        {
            int maxElementIndex = int.MinValue;
            int maxElement = 0;
            bool isThereEvenOrOddElement = false;

            if (evenOrOdd == "even")
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % 2 == 0)
                    {
                        if (inputArray[i] >= maxElement)
                        {
                            maxElement = inputArray[i];
                            maxElementIndex = i;
                            isThereEvenOrOddElement = true;
                        }
                    }
                }
            }

            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % 2 != 0)
                    {
                        if (inputArray[i] >= maxElement)
                        {
                            maxElement = inputArray[i];
                            maxElementIndex = i;
                            isThereEvenOrOddElement = true;
                        }
                    }
                }
            }
            if (isThereEvenOrOddElement == false)
            {
                Console.WriteLine("No matches");
                return;
            }

            else
            {
                Console.WriteLine(maxElementIndex);
                return;
            }
        }

        public static void FindMinEvenOrOddElement(int[] inputArray, string evenOrOdd)
        {
            int minElement = int.MaxValue;
            int minElementIndex = 0;
            bool isThereEvenOrOddElement = false;

            if (evenOrOdd == "even")
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % 2 == 0)
                    {
                        if (inputArray[i] <= minElement)
                        {
                            isThereEvenOrOddElement = true;
                            minElement = inputArray[i];
                            minElementIndex = i;
                        }
                    }
                }
            }

            else if (evenOrOdd == "odd")
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] % 2 != 0)
                    {
                        if (inputArray[i] <= minElement)
                        {
                            isThereEvenOrOddElement = true;
                            minElement = inputArray[i];
                            minElementIndex = i;
                        }
                    }
                }
            }
            if (isThereEvenOrOddElement == false)
            {
                Console.WriteLine("No matches");
                return;
            }

            else
            {
                Console.WriteLine(minElementIndex);
                return;
            }
        }

        public static void ReturnFirstCountElements(int[] inputArray, int count, string EvenOrOdd)
        {
            int temporaryCount = 0;
            List<int> result = new List<int>();

            if (count > inputArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (EvenOrOdd == "even")
                {
                    if (inputArray[i] % 2 == 0)
                    {
                        temporaryCount++;
                        result.Add(inputArray[i]);

                        if (temporaryCount >= count)
                        {
                            break;
                        }
                    }
                }
                else if (EvenOrOdd == "odd")
                {
                    if (inputArray[i] % 2 != 0)
                    {
                        temporaryCount++;
                        result.Add(inputArray[i]);

                        if (temporaryCount >= count)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }

        public static void ReturnLastCountElements(int[] inputArray, int count, string evenOrOdd)
        {
            int temporaryCount = 0;
            List<int> result = new List<int>();

            if (count > inputArray.Length)
            {
                Console.WriteLine("invalid count");
                return;
            }

            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                if (evenOrOdd == "even")
                {
                    if (inputArray[i] % 2 == 0)
                    {
                        temporaryCount++;
                        result.Add(inputArray[i]);

                        if (temporaryCount >= count)
                        {
                            break;
                        }
                    }
                }

                else if (evenOrOdd == "odd")
                {
                    if (inputArray[i] % 2 != 0)
                    {
                        temporaryCount++;
                        result.Add(inputArray[i]);

                        if (temporaryCount >= count)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
