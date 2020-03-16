using System;
using System.Linq;
using System.Collections.Generic;

namespace validUsernames1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                string currentUsername = usernames[i];

                if (CheckIfLenghtIsValid(currentUsername) && CheckIfContentIsValid(currentUsername))
                {
                    Console.Write(currentUsername);
                    Console.WriteLine();
                }
            }
        }

        public static bool CheckIfLenghtIsValid(string curentUsername)
        {
                if (curentUsername.Length >= 3 && curentUsername.Length < 16)
                {
                    return true;
                }
                return false;
        }

        public static bool CheckIfContentIsValid(string currentUsername)
        {
            bool isValid = false;
            for (int i = 0; i < currentUsername.Length; i++)
            {
                char currentChar = currentUsername[i];

                if (char.IsLetterOrDigit(currentChar) || currentChar == '-' ||
                    currentChar == '_')
                {
                    isValid = true;
                }
                else
                {
                   return isValid = false;
                }
            }
            return isValid;
        }
    }
}
