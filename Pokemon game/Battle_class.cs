using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trainer_class;
using Pokemon_subclasses;
using Arena_class;
using battle_class;
using Pokemon_class;
using Pokeball_class;

namespace battle_class

{
    public class Battle
    {
        private trainer trainer1;
        private trainer trainer2;
        private Pokemon currentPokemon1;
        private Pokemon currentPokemon2;
        private Pokemon pokemon_removed;
        public Battle(trainer t1, trainer t2)
        {
            trainer1 = t1;
            trainer2 = t2;
        }

        private string check_for_weakness(Pokemon pokemonA, Pokemon pokemonB)
        {
            if ((pokemonA.strength == "Fire" && pokemonB.weakness == "Grass") ||
                (pokemonA.strength == "Grass" && pokemonB.weakness == "Water") ||
                (pokemonA.strength == "Water" && pokemonB.weakness == "Fire"))
            {
                return "Player 1";
            }
            else if
                ((pokemonB.strength == "Fire" && pokemonA.weakness == "Grass") ||
                (pokemonB.strength == "Grass" && pokemonA.weakness == "Water") ||
                (pokemonB.strength == "Water" && pokemonA.weakness == "Fire"))
            {
                return "Player 2";
            }
            else
            {
                return "Draw";
            }

        }          
     

        private bool checkforwinners()
        {
            if (!trainer1.haspokemonleft())
            {
                Console.WriteLine("Congratulations " + trainer2.name + "  Has won");
                return true;
            }
            else if (!trainer2.haspokemonleft() )
            {
                Console.WriteLine("Congratulations " + trainer1.name + " Has won");
                return true;

            }
            else
                return false;
        }



        private void the_battle()
        {


            Console.WriteLine(currentPokemon1.naam + " Attacks " + currentPokemon2.naam);
            string winner = check_for_weakness(currentPokemon1, currentPokemon2);


            if (winner == "Player 1")
            {
                
                Console.WriteLine(currentPokemon1.naam + " Used a " + currentPokemon1.strength + " Attack.\n");
                Console.WriteLine("Congratulations " + trainer1.name + " won the battle\n");


                pokemon_removed = currentPokemon2; // add the defeated pokemon to the pokemon_removed variable to be removed

                currentPokemon2 = trainer2.GetRandomPokemon("Trainer: " + trainer1.name); // pick another pokemon from the belt 


                Console.WriteLine("Removing " + pokemon_removed.naam + " from " + trainer2.name + "'s belt.\n");
                
                pokeball pokeballToRemove = trainer2.belt.FirstOrDefault(pokeball => pokeball.ContainedPokemon == pokemon_removed); // removing the pokemon that exists in the pokemon_removed variable
                if(pokeballToRemove != null)
                {
                    trainer2.RemovePokemonFromBelt(pokeballToRemove, trainer1);
                }
                currentPokemon2 = trainer2.GetRandomPokemon("Trainer: " + trainer2.name);
            }






            else if (winner == "Player 2")
            {
                
                Console.WriteLine(currentPokemon2.naam + " Used a " + currentPokemon2.strength + " Attack.\n");
                Console.WriteLine("Congratulations " + trainer2.name + " won the battle\n");
                
                pokemon_removed = currentPokemon1; // add the defeated pokemon to the pokemon_removed variable to be removed


                currentPokemon1 = trainer1.GetRandomPokemon("Trainer: " + trainer1.name); // pick another pokemon from the belt 

                Console.WriteLine("Removing " + pokemon_removed.naam + " from " + trainer1.name + "'s belt.\n");

                pokeball pokeballToRemove = trainer1.belt.FirstOrDefault(pokeball => pokeball.ContainedPokemon == pokemon_removed); // removing the pokemon that exists in the pokemon_removed variable
                if (pokeballToRemove != null)
                {
                    trainer1.RemovePokemonFromBelt(pokeballToRemove, trainer2);
                }
                currentPokemon1 = trainer1.GetRandomPokemon("Trainer: " + trainer1.name);


            }
            else
            {
                Console.WriteLine(currentPokemon1.naam + " Used a " + currentPokemon1.strength + " Attack.\n");
                Console.WriteLine("its a tie both pokemons will be returned to their pokeballs\n");
                currentPokemon1 = trainer1.GetRandomPokemon("Trainer: " + trainer1.name);
                currentPokemon2 = trainer2.GetRandomPokemon("Trainer: " + trainer2.name);
            }

            Console.ReadKey();
        }
        public void startbattle(trainer trainer1, trainer trainer2)
        {
            currentPokemon1 = trainer1.GetRandomPokemon("Trainer: " + trainer1.name);
            currentPokemon2 = trainer2.GetRandomPokemon("Trainer: " + trainer2.name);

            while (trainer1.haspokemonleft() && trainer2.haspokemonleft())
            {
                
                the_battle();

            }
            checkforwinners();
        }
    }
}
   
    
