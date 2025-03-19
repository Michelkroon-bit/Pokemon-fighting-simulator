using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pokemon_battle_simulator
{
    public class pokeball
    {
        public Pokemon? ContainedPokemon { get; private set; }
        public bool IsOpen { get; private set; }
        public bool IsUsed { get; private set; }

        public pokeball(Pokemon pokemon)
        {
            ContainedPokemon = pokemon;
            IsOpen = false;
        }

     

        public void Throw()
        {
            if (ContainedPokemon != null && !IsOpen)
            {
                if (!IsUsed)
                {
                    IsOpen = true;
                    IsUsed = true;
                 
                }

                IsOpen = true;
                Console.WriteLine(ContainedPokemon.naam + " does a battle cry ");
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
            
        public void ResetPokemon()
        {   
            if (ContainedPokemon != null)
            {
                IsUsed = false;

            }
            else
            {
                Console.WriteLine("No Pokémon to return or the Pokéball has not been used yet.");
            }
        }
    }
}