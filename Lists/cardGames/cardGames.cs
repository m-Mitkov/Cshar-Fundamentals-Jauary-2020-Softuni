using System;
using System.Collections.Generic;
using System.Linq;

namespace cardGames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToList();

            List<int> playerTwo = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < playerOne.Count; i++)
            {
                if (playerTwo.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
                    return;
                }

                int playerOneCard = playerOne[0];
                int playerTwoCard = playerTwo[0];

                if (playerOneCard > playerTwoCard)
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);

                    playerOne.Add(playerOneCard);
                    playerOne.Add(playerTwoCard);
                }

                else if (playerTwoCard > playerOneCard)
                {
                    playerTwo.RemoveAt(0);
                    playerOne.RemoveAt(0);

                    playerTwo.Add(playerTwoCard);
                    playerTwo.Add(playerOneCard);
                }

                else
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
                i--;
            }

            Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
        }
    }
}
