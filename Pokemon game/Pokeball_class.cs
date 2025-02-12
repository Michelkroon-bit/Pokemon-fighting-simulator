using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Poke_balls
{
    using Pokemons;
    public class pokeballs
    {
        public Pokemon? ContainedPokemon { get; private set; }
        public bool IsOpen { get; private set; }

        public pokeballs(Pokemon pokemon)
        {
            ContainedPokemon = pokemon;
            IsOpen = false;
        }

        public void Throw()
        {
            if (ContainedPokemon != null && !IsOpen)
            {
                IsOpen = true;
                Console.WriteLine("You threw a pokeball " + ContainedPokemon.naam + " has been released");
                Pokemon.battlecry(ContainedPokemon.naam);
            }
            else
            {
                Console.WriteLine("The Pokéball is empty or already open");
            }
        }
        public void ReturnPokemon()
        {
            if (!IsOpen && ContainedPokemon != null)
            {
                IsOpen = false;
                Console.WriteLine($"{ContainedPokemon.naam} has returned to its Pokéball.");
            }
            else
            {
                Console.WriteLine("No Pokémon to return.");
            }
        }
    }
}