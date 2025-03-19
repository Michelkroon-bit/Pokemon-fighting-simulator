using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_battle_simulator;

namespace Pokemon_battle_simulator
{
    public static class arena_class
    {
        private static int roundsdone = 0;
        private static int battlesfought = 0;

        public static void StartBattle(trainer trainer1, trainer trainer2)
        {
            battlesfought++;
            Console.WriteLine("Battle " + battlesfought + " Begins now.\n");



            Battle battle = new Battle(trainer1, trainer2);
            


            
            Console.WriteLine("Total battles fought: " + battlesfought);
            Console.WriteLine("Total rounds played: " + roundsdone);
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("|Total battles fought   | Total rounds done      |");
            Console.WriteLine("------------------------|-------------------------");
            Console.WriteLine("total" + battlesfought, + roundsdone);
            Console.WriteLine("|------------------------------------------------|");
        }
    }
}
