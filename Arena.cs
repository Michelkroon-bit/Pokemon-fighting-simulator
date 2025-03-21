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
           
            Console.WriteLine("Battle " + battlesfought + " Begins now.\n");
            Battle battle = new Battle(trainer1, trainer2);

            battlesfought++;
            for (int i = 0; i < battle.aantalrondes; i++)
            {
                roundsdone++;
            }





            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("| Total battles fought  | Total rounds done      |");
            Console.WriteLine("------------------------|------------------------");
            Console.WriteLine($"| Total {battlesfought,-10}      | Total {roundsdone,-10}       |");
            Console.WriteLine("|------------------------------------------------|");

        }
    }
}
