using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_battle_simulator;

namespace Pokemon_battle_simulator
{
    public class Charmander : Pokemon //Charmander subclass
    {
        public Charmander(string naam) : base(naam, "Fire", "grass", 25, 6)
        {
        }
        public override void battlecry()
        {
            Console.WriteLine(naam + " shouts: Char, Char!");
        }
    }


    public class Bulbasaur : Pokemon // bulbasaur subclass
    {
        public Bulbasaur(string naam) : base(naam, "Grass", "Fire", 20, 4)
        {
        }
        public override void battlecry()
        {
            Console.WriteLine(naam + " shouts: Bulba, Bulba!");
        }
    }


    public class Squirtle : Pokemon // squirtle subclass
    {
        public Squirtle(string naam) : base(naam, "Water", "grass", 15, 5)
        {
        }
        public override void battlecry()//By overriding, you ensure that each Pokemon has its own special way of shouting its battle cry. Without overriding, we wouldn't be able to customize it for each type!
        {
            Console.WriteLine(naam + " shouts: Squirtle, Squirtle!");
        }
    }
};