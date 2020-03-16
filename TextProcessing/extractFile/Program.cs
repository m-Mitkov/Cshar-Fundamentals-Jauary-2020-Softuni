using System;

namespace extractFile1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Console.ReadLine()
                .Split("\\");

            string fileToUse = files[files.Length - 1];

            string[] fileToUseArgs = fileToUse.Split(".");

            string fileName = fileToUseArgs[0];
            string fileExtension = fileToUseArgs[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
