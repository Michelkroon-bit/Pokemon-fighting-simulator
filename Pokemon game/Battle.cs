using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_battle_simulator;


namespace Pokemon_battle_simulator
{
    public class Battle
    {
        private trainer trainer1;
        private trainer trainer2;

       
        public Battle(trainer trainer1, trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
            
               
            Random rnd = new();
           

            while (true)
            {
                Console.WriteLine("\nThe battle begins now \n");
                int Randomt1 = rnd.Next(1, 6);

                for (int round = 1; round <= 6; round++)
                {


                    Console.WriteLine(trainer1.name + " throws their pokeball\n");
                  
                    var pokeballs_player_1 = trainer1.belt[Randomt1];

                    pokeballs_player_1.Throw();
                    Console.ReadLine();

                    Console.WriteLine(trainer2.name + " throws their Pokéball!\n");
                    var pokeballs_player_2 = trainer2.belt[rnd.Next(1, 6)];
                    pokeballs_player_2.Throw();
                    Console.ReadLine();

            
              


                Console.WriteLine(trainer1.name + " has returned it's pokémon to their Pokéball.\n");
                    pokeballs_player_1.ReturnPokemon();
                    Console.ReadLine();

                    Console.WriteLine(trainer2.name + " has returned it's pokémon to their Pokéball.\n");
                    pokeballs_player_2.ReturnPokemon();

                    Console.WriteLine("Round " + round + " ended\n");
                    Thread.Sleep(500);
                };

                Console.WriteLine("\nPress Enter to replay, type 'X' to quit.\n");
                string input_keep_playing = Console.ReadLine();

                if (input_keep_playing.ToUpper() == "X")
                {
                    Console.WriteLine("Thanks for playing :)");
                    Thread.Sleep(1500);
                    break;
                }
                else
                {
                    Console.WriteLine("Restarting Battle...");
                }
            };
        }
    }
}

