using System;

namespace stringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int explosionPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '>')
                {
                    explosionPower += int.Parse(input[i + 1].ToString());
                }

                else if (explosionPower > 0)
                {
                    input = input.Remove(i, 1);
                    explosionPower--;
                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
