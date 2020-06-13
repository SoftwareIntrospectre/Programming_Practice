using System;
using System.Collections.Generic;

namespace DictionaryCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon()
            {
                PokedexNumber = 152,
                PokemonName = "Chikorita",
                PokemonType = PokemonType.Grass
            };

            Pokemon pokemon2 = new Pokemon()
            {
                PokedexNumber = 155,
                PokemonName = "Cyndaquil",
                PokemonType = PokemonType.Fire
            };

            Pokemon pokemon3 = new Pokemon()
            {
                PokedexNumber = 158,
                PokemonName = "Totodile",
                PokemonType = PokemonType.Water
            };

            Pokemon pokemon4 = new Pokemon()
            {
                PokedexNumber = 200,
                PokemonName = "Misdreavus",
                PokemonType = PokemonType.Ghost
            };

            Pokemon pokemon5 = new Pokemon()
            {
                PokedexNumber = 151,
                PokemonName = "Mew",
                PokemonType = PokemonType.Psychic
            };
            
            SortedList<int, Pokemon> pokemonSortedList = new SortedList<int, Pokemon>();
            
            pokemonSortedList.Add(pokemon1.PokedexNumber, pokemon1);
            pokemonSortedList.Add(pokemon2.PokedexNumber, pokemon2);
            pokemonSortedList.Add(pokemon3.PokedexNumber, pokemon3);
            pokemonSortedList.Add(pokemon4.PokedexNumber, pokemon4);
            pokemonSortedList.Add(pokemon5.PokedexNumber, pokemon5);

            foreach(KeyValuePair<int, Pokemon> pokemonKVPair in pokemonSortedList)
            {
                Console.WriteLine("Pokedex ID: " + pokemonKVPair.Key + "\nPokemon Name: " + pokemonKVPair.Value.PokemonName +  "\nPokemon Type: " + pokemonKVPair.Value.PokemonType +  "\n\n");
            }
        }
    }
    
    public enum PokemonType
    {
        Normal,
        Fighting,
        Flying,
        Poison,
        Ground,
        Bug,
        Ghost,
        Steel,
        Fire,
        Water,
        Grass,
        Electric,
        Psychic,
        Dragon,
        Dark,
        Fairy
    };

    class Pokemon
    {
        public int PokedexNumber {get;set;}
        public string PokemonName {get;set;}

        public PokemonType PokemonType {get;set;}
    }
}

