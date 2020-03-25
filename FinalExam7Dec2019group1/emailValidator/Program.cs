using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace emailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            while (true)
            {
                string[] comand = Console.ReadLine().Split(" ");

                if (comand[0] == "Complete")
                {
                    break;
                }
                string toDo = comand[0];

                if (toDo == "Make")
                {
                    if (comand[1] == "Upper")
                    {
                        email = email.ToUpper();
                    }
                    else
                    {
                        email = email.ToLower();
                    }
                    Console.WriteLine(email);
                }

                else if (toDo == "GetDomain")
                {
                    int countOfChars = int.Parse(comand[1]);
                    string result = "";

                    for (int i = email.Length - countOfChars; i < email.Length; i++)
                    {
                        result += email[i];
                    }

                    Console.WriteLine(result);
                }

                else if (toDo == "GetUsername")
                {
                    if (!email.Contains('@'))
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        string result = "";

                        for (int i = 0; i < email.Length - 1; i++)
                        {
                            char currentChar = email[i];

                            if (currentChar == '@')
                            {
                                break;
                            }
                            else
                            {
                                result += currentChar;
                            }
                        }
                        Console.WriteLine(result);
                    }
                }

                else if (toDo == "Replace")
                {
                    char charToReplace = char.Parse(comand[1]);

                    email = email.Replace(charToReplace, '-');

                    Console.WriteLine(email);
                }

                else if (toDo == "Encrypt")
                {
                    for (int i = 0; i < email.Length; i++)
                    {
                        int currentChar = email[i];

                        Console.Write(currentChar + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
