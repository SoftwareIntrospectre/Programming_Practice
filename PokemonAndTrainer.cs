using System;

namespace ProgrammingFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon nidoking = new Pokemon("Nidoking", 100, false);
            Pokemon pikachu = new Pokemon("Pikachu", 30, true, nidoking);

            PokemonTrainer trainerBlue = new PokemonTrainer("Blue", 5, 8, nidoking);
            PokemonTrainer trainerRed = new PokemonTrainer("Red", 6, 6, pikachu);

            trainerBlue.TrainerDetail();
            trainerBlue.TrainerPokemonDetail();

            trainerRed.TrainerDetail();
            trainerRed.TrainerPokemonDetail();
        }
    }

    class Pokemon
    {
        public Pokemon(string pokemonName, int hitPoints, bool canEvolve, Pokemon opponentPokemon)
        {
            this.PokemonName = pokemonName;
            this.HitPoints = hitPoints;
            this.CanEvolve = canEvolve;
            this.OpponentPokemon = opponentPokemon;
        }

         public Pokemon(string pokemonName, int hitPoints, bool canEvolve)
        {
            this.PokemonName = pokemonName;
            this.HitPoints = hitPoints;
            this.CanEvolve = canEvolve;
        }

        public string PokemonName{get;set;}
        public int HitPoints{get;set;}

        public bool CanEvolve{get;set;}

        public Pokemon OpponentPokemon{get;set;}
    }

    class PokemonTrainer
    {
        public PokemonTrainer(string trainerName, int pokemonCount, int badgesCount, Pokemon pokemonOwned)
        {
            this.TrainerName = trainerName;
            this.PokemonCount = pokemonCount;
            this.BadgesCount = badgesCount;
            this.PokemonOwned = pokemonOwned;
        }

        public string TrainerName{get;set;}
        public int PokemonCount{get;set;}

        public int BadgesCount{get;set;}

        public Pokemon PokemonOwned{get;set;}

        public void TrainerDetail()
        {
            Console.WriteLine("Trainer name is: " + TrainerName + ". Pokemon count is: "  + PokemonCount + ". Badges count is: " + BadgesCount);
        }

        public void TrainerPokemonDetail()
        {
            Console.WriteLine("Pokemon is: " + PokemonOwned.PokemonName + ". Their HP is: " + PokemonOwned.HitPoints + ". Can they evolve? " + PokemonOwned.CanEvolve+ ".");
            if(PokemonOwned.OpponentPokemon != null)
            {
                Console.WriteLine("Opponent Pokemon is: " + PokemonOwned.OpponentPokemon.PokemonName + ". \n");
            } 

            else
            {
                Console.WriteLine("No opponent Pokemon. \n");
            }
        }
    }
}
