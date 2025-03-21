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
        private Random rnd = new Random();
        public int aantalrondes = 6;
        public Battle(trainer trainer1, trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;


        void Battlezelf(string pkmtype1, string pkmtype2)
        {
            switch ((pkmtype1, pkmtype2))
            {
                case ("Fire", "Grass"):
                    Console.WriteLine("Fire type wint");

                    break;

                case ("Water", "Fire"):
                    Console.WriteLine("Water type wint");

                    break;

                case ("Grass", "Water"):
                    Console.WriteLine("Grass type wint");

                    break;
                case ("Grass", "Fire"):
                    Console.WriteLine("Fire type wint");

                    break;

                case ("Fire", "Water"):
                    Console.WriteLine("Water type wint");

                    break;

                case ("Water", "Grass"):
                    Console.WriteLine("Grass type wint");

                    break;

                default:
                Console.WriteLine("Twee keer het type "+pkmtype1+" gelijkspel");
                break;
            }
        };

            while (true)
            {
                Console.WriteLine("\nThe battle begins now!\n");

                for (int round = 1; round <= aantalrondes; round++)
                {
                    int Randomt1, Randomt2;

                   
                    do
                    {
                        Randomt1 = rnd.Next(0, aantalrondes);
                    } while (trainer1.belt[Randomt1].IsUsed);

                    Console.WriteLine(trainer1.name + " throws their Pokéball!\n");
                    var pokeballs_player_1 = trainer1.belt[Randomt1];
                    pokeballs_player_1.Throw();
                    Console.ReadLine();
  
                    do
                    {
                        Randomt2 = rnd.Next(0, aantalrondes);
                    } while (trainer2.belt[Randomt2].IsUsed);

                    Console.WriteLine(trainer2.name + " throws their Pokéball!\n");
                    var pokeballs_player_2 = trainer2.belt[Randomt2];
                    pokeballs_player_2.Throw();
                    Console.ReadLine();

                    var pkmtype1 = trainer1.belt[Randomt1].ContainedPokemon.strength;
                    var pkmtype2 = trainer2.belt[Randomt2].ContainedPokemon.strength;
                


                    Battlezelf(pkmtype1, pkmtype2);

                    Console.WriteLine(trainer1.name + " has returned its Pokémon to their Pokéball.\n");
                    pokeballs_player_1.ReturnPokemon();
                    Console.ReadLine();

                    Console.WriteLine(trainer2.name + " has returned its Pokémon to their Pokéball.\n");
                    pokeballs_player_2.ReturnPokemon();

                    Console.WriteLine("Round " + round + " ended\n");
                    Thread.Sleep(500);
                }
                
             
                    for (int i = 0; i < aantalrondes; i++)
                    {
                        trainer1.belt[i].ResetPokemon();
                        trainer2.belt[i].ResetPokemon();
                    }
                break;








            }
            }
        }
    }
//}
