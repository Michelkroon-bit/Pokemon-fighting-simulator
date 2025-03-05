using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trainer_class;
using Pokemon_subclasses;
using Pokemon_class;
using battle_class;
using Pokeball_class;

namespace Arena_class
{
    public static class arena_class
    {
        private static int totalroundsplayed = 0;
        private static int totalbattlesfought = 0;

        public static void StartBattle(trainer trainer1 ,trainer trainer2)
        {
            totalbattlesfought++;
            Console.WriteLine("Battle " + totalbattlesfought + " Begins now.\n");



            Battle battle = new Battle(trainer1,trainer2);
            int round = 1;


            battle.startbattle(trainer1, trainer2);
            totalbattlesfought += round;
            Console.WriteLine("Round " + round + " Starts.");


            Console.WriteLine("Total battles fought: " + totalbattlesfought);
            Console.WriteLine("Total rounds played: " + totalroundsplayed);
        }
    }
}


