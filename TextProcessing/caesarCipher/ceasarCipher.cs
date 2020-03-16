using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace caesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToEncrypt = Console.ReadLine();

            int encryptingCode = 3;

            StringBuilder cryptedText = new StringBuilder(textToEncrypt);

            for (int i = 0; i < textToEncrypt.Length; i++)
            {
                int encryptedSymbol = textToEncrypt[i] + encryptingCode;

                cryptedText[i] = Convert.ToChar(encryptedSymbol);
            }

            Console.WriteLine(cryptedText.ToString());
        }
    }
}
