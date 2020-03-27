using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace messageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternComand = new Regex(@"!([A-Z][a-z]{2,})!");
            Regex patternMessage = new Regex(@"\[([A-Za-z]{8,})\]");

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                string[] currentMessage = Console.ReadLine().Split(":");

                string commandArgs = currentMessage[0];
                string messageArgs = currentMessage[1];

                if (patternComand.IsMatch(commandArgs) && patternMessage.IsMatch(messageArgs))
                {
                    string command = patternComand.Match(commandArgs).Groups[1].ToString();
                    string message = patternMessage.Match(messageArgs).Groups[1].ToString();

                    List<int> decryptedMessage = new List<int>();

                    for (int j = 0; j < message.Length; j++)
                    {
                        decryptedMessage.Add(message[j]);
                    }

                    Console.WriteLine($"{command}: {string.Join(" ", decryptedMessage)}");
                }

                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
