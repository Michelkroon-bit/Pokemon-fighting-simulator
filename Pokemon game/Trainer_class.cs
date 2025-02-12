using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pokemon_battle_simulator
{

    public class trainer
    {
        public string name { get; set; }
        public List<pokeball> belt { get;  set; }

        public trainer(string name)
        {
            this.name = name;
            belt = new List<pokeball>();

            for (int i = 0; i < 6; i++)
            {
                belt.Add(new pokeball(new Pokemon("Charmander", "Fire", "Water", 10, 4)));
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
