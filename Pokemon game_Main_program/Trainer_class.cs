using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pokemon_class;
using battle_class;
using Pokemon_subclasses;
using Pokeball_class;
using Arena_class;


namespace Trainer_class

{

    public class trainer
    {
        public string name { get; private set; }
        public List<pokeball> belt { get; private set; }

        public trainer(string name)
        {
            this.name = name;
            belt = new List<pokeball>();

            addPokemonToBelt("Charmander", 2);
            addPokemonToBelt("Squirtle", 2);
            addPokemonToBelt("Bulbasaur", 2);

            
        }

        private void addPokemonToBelt(string Pokemontype, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (Pokemontype.ToLower())
                {
                    case "charmander":
                        belt.Add(new pokeball(new Charmander("Charmander " + i)));
                        break;

                    case "squirtle":
                        belt.Add(new pokeball(new Squirtle("Squirtle " + i)));
                        break;

                    case "bulbasaur":
                        belt.Add(new pokeball(new Bulbasaur("Bulbasaur " + i)));
                        break;

                    default:
                        Console.WriteLine("Pokemon not found unknown type");
                        break;


                }
            }
        }
        public void ThrowPokeball(int index)
        {
            if (index >= 0 && index < belt.Count)
            {
                belt[index].Throw();
            }
            else
            {
                Console.WriteLine("Invalid Pokéball index!");
            }
        }



        public void ReturnPokemon(int index)
        {
            if (index >= 0 && index < belt.Count)
            {
                belt[index].ReturnPokemon();
            }
            else
            {
                Console.WriteLine("Invalid Pokéball index!");
            }
        }
        public bool haspokemonleft()
        {
            if (belt.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Pokemon GetRandomPokemon(string name)
        {
            Random random = new Random();
            List<pokeball> AvailablePokeballs = belt.FindAll(pokeball => pokeball.ContainedPokemon != null); // create a list of each pokeball where a pokemon is contained

            if (AvailablePokeballs.Count == 0)
            {
                Console.WriteLine(name + " has no more Pokémon left.");
                return null;
            }
            pokeball selectedPokeball = AvailablePokeballs[random.Next(AvailablePokeballs.Count)];
            Pokemon selectedPokemon = selectedPokeball.ContainedPokemon;
            

            return selectedPokemon;
        }
        public void RemovePokemonFromBelt(pokeball selectedPokeball, trainer trainer)
        {
            belt.Remove(selectedPokeball);
            
        }
    }
}