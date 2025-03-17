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
                        belt.Add(new pokeball(new Squirtle("Squirtle " +i)));
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
