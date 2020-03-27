using System;
using System.Linq;
using System.Collections.Generic;

namespace nikuldenCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string cryptedComand = Console.ReadLine();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(" ");

                if (comand[0] == "Finish")
                {
                    break;
                }

                string toDo = comand[0];

                if (toDo == "Replace")
                {
                    string currentChar = comand[1];
                    string newChar = comand[2];

                    cryptedComand = cryptedComand.Replace(currentChar, newChar);

                    Console.WriteLine(cryptedComand);
                }

                else if (toDo == "Cut")
                {
                    int startIndex = int.Parse(comand[1]);
                    int endIndex = int.Parse(comand[2]);

                    if (startIndex >= 0 && endIndex <= cryptedComand.Length)
                    {
                        cryptedComand = cryptedComand.Remove(startIndex, endIndex);
                        Console.WriteLine(cryptedComand);

                        continue;
                    }
                    Console.WriteLine("Invalid indexes!");
                }

                else if (toDo == "Make")
                {
                    string UpperOrLower = comand[1];

                    if (UpperOrLower == "Upper")
                    {
                        cryptedComand = cryptedComand.ToUpper();
                    }
                    else
                    {
                        cryptedComand = cryptedComand.ToLower();
                    }

                    Console.WriteLine(cryptedComand);
                }

                else if (toDo == "Check")
                {
                    string stringToCheck = comand[1];

                    if (cryptedComand.Contains(stringToCheck))
                    {
                        Console.WriteLine($"Message contains {stringToCheck}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {stringToCheck}");
                    }
                }

                else if (toDo == "Sum")
                {
                    int startIndex = int.Parse(comand[1]);
                    int endIndex = int.Parse(comand[2]);

                    if (startIndex >= 0 && endIndex <= cryptedComand.Length)
                    {
                        int sumASCIIvalues = 0;

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sumASCIIvalues += cryptedComand[i];
                        }

                        Console.WriteLine(sumASCIIvalues);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
            }
        }
    }
}
