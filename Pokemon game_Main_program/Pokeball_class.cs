using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trainer_class;
using Pokemon_subclasses;
using Arena_class;
using battle_class;
using Pokeball_class;

namespace Pokeball_class
{
    public class pokeball
    {
        public Pokemon_class.Pokemon ContainedPokemon { get; private set; }
        public bool IsOpen { get; private set; }

        public pokeball(Pokemon_class.Pokemon pokemon)
        {
            ContainedPokemon = pokemon;
            IsOpen = false;
        }

        public void Throw()
        {
            if (ContainedPokemon != null && !IsOpen)
            {
                IsOpen = true;
                Console.WriteLine(ContainedPokemon.Name + " does a battle cry ");
                ContainedPokemon.battlecry();
            }
            else
            {
                Console.WriteLine("The Pokéball is empty or already open");
            }
        }
        public void ReturnPokemon()
        {
            if (IsOpen && ContainedPokemon != null)
            {
                IsOpen = false;
                   
            }
            else
            {
                Console.WriteLine("No Pokémon to return or the Pokéball is already closed.");
            }
        }
    }
}