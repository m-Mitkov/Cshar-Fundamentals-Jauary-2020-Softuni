using System;
using System.Linq;

namespace CommonElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            string commonElements = string.Empty;

            foreach (var element in secondInput)
            {
                if (firstInput.Contains(element))
                {
                    commonElements += element + ' ';
                }
            }

            Console.WriteLine(commonElements);
        }
    }
}
