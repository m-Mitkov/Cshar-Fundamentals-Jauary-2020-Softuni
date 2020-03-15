using System;
using System.Linq;
using System.Collections.Generic;

namespace stackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();

            int capturedPokemon = 0;
            int capturedPokemonSum = 0;

            while (pokemons.Count > 0)
            {
                int indexPokemon = int.Parse(Console.ReadLine());

                if (indexPokemon < 0)
                {
                    capturedPokemon = CopyLastElementBecomeFirst(pokemons);
                }

                else if (indexPokemon >=     pokemons.Count)
                {
                    capturedPokemon = CopyFirstElementBecomeLast(pokemons);
                }

                else
                {
                    capturedPokemon = pokemons[indexPokemon];
                    pokemons.RemoveAt(indexPokemon);
                }

                capturedPokemonSum += capturedPokemon;
                DistanceReavalution(pokemons, capturedPokemon);
            }

            Console.WriteLine(capturedPokemonSum);
        }

        public static int CopyLastElementBecomeFirst(List<int> pokemons)
        {
            int currentPokoemon = pokemons[0];
            pokemons[0] = pokemons[pokemons.Count - 1];
            return currentPokoemon;
        }

        public static int CopyFirstElementBecomeLast(List<int> pokemons)
        {
            int currentPokemon = pokemons[pokemons.Count - 1];
            pokemons[pokemons.Count - 1] = pokemons[0];
            return currentPokemon;
        }

        public static void DistanceReavalution(List<int> pokemons, int capturedPokemon)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                // NOTE BE CAREFUL  !!!
                // int currentPokemon = pokemos[i] ==> does not change the values in the list, 
                // it works only like a local varialble !!!!!!!!!
                if (capturedPokemon >= pokemons[i])
                {
                    pokemons[i] += capturedPokemon;
                }
                else if (capturedPokemon < pokemons[i])
                {
                    pokemons[i] -= capturedPokemon;
                }
            }
        }
    }
}
