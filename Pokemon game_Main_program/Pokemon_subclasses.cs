using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trainer_class;
using Pokemon_class;
using battle_class;
using Pokeball_class;
using Arena_class;

namespace Pokemon_subclasses
{   

    // a charmander subclass with a custom overwrite battle cry 
    public class Charmander : Pokemon_class.Pokemon //Charmander subclass
    {
        public Charmander(string naam) : base(naam, strengthlevels.High, weaknesslevels.Low, 25, 16 , "Fireblast")
        {
        }
        public override void battlecry()///By overriding, you ensure that each Pokemon has its own special way of shouting its battle cry
        {
            Console.WriteLine(Name + " shouts: Char, Char!");
        }
    }


    public class Bulbasaur : Pokemon // bulbasaur subclass
    {

        // a Bulbasaur subclass with a custom overwrite battle cry 
        public Bulbasaur(string naam) : base(naam, strengthlevels.Middle, weaknesslevels.High, 20, 14 , "Leafslap")
        {
        }
        public override void battlecry()
        {
            Console.WriteLine(Name + " shouts: Bulba, Bulba!");
        }
    }


    public class Squirtle : Pokemon // squirtle subclass
    {

        // a Squirtle subclass with a custom overwrite battle cry 

        public Squirtle(string naam) : base(naam, strengthlevels.Middle, weaknesslevels.High, 25, 15, "Waterstorm")
        {
        }
        public override void battlecry()
        {
            Console.WriteLine(Name + " shouts: Squirtle, Squirtle!");
        }
    }
};