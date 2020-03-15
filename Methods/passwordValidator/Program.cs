using System;
using System.Linq;
using System.Collections.Generic;

namespace passwordValidator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool lengthIsValid = true;
            bool letterAndDigitsIsValid = true;
            bool atLeastTwoDigitsIsValid = true;

          lengthIsValid = ChechifLengthIsValid(password, lengthIsValid);
          letterAndDigitsIsValid = CheckIfConsistLetterAndDigit(password, letterAndDigitsIsValid);
          atLeastTwoDigitsIsValid = CheckAtLeastTwoDigits(password, atLeastTwoDigitsIsValid);

            if (lengthIsValid && letterAndDigitsIsValid && atLeastTwoDigitsIsValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        public static bool ChechifLengthIsValid(string password, bool lengthIsValid)
        {
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                lengthIsValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            return lengthIsValid;
        }

        public static bool CheckIfConsistLetterAndDigit(string password, bool letterAndDigitIsValid)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    letterAndDigitIsValid = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }
            return letterAndDigitIsValid;
        }

        public static bool CheckAtLeastTwoDigits(string password, bool atLeastTwoDigitsIsValid)
        {
            int countDigits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    countDigits++;
                }
                if (countDigits == 2)
                {
                    return atLeastTwoDigitsIsValid;
                }
            }

            Console.WriteLine("Password must have at least 2 digits");
            return atLeastTwoDigitsIsValid;
        }
    }
}
