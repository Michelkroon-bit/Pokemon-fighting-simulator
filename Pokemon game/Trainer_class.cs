using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poke_balls;
using Pokemons;

namespace Trainers
{

    public class trainer
    {
        public string name { get; set; }
        public List<pokeballs> belt { get; private set; }

        public trainer(string name)
        {
            name = name;
            belt = new List<pokeballs>();

            for (int i = 0; i < 6; i++)
            {
                belt.Add(new pokeballs(new Pokemon("Charmander", "Fire", "Water", 10, 4)));
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
            if(index >=  0 && index < belt.Count)
            {
                belt[index].ReturnPokemon();
            }
            else
            {
                Console.WriteLine("Invalid Pokéball index!");
            }
        }
    }
}
