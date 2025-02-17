using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon_battle_simulator;

/*notes
Abstract classes are like blueprints for other classes. You can't create an object directly from an abstract class, but you can create objects from classes that "inherit" from it. 
 */



namespace Pokemon_battle_simulator
{
    public abstract class Pokemon 

    {
        public string naam { get; set; }
        public string strength { get; set; }
        public string weakness  { get; set; }
        public int HP { get; set; }
        public int Atk { get; set; }


        public Pokemon(string naam ,string strength , string weakness , int HP , int Atk) 
        {
            this.naam = naam;
            this.strength = strength;
            this.weakness = weakness;
            this.HP = HP;
            this.Atk = Atk;
        }
<<<<<<< HEAD:Pokemon game/Class1.cs
        public static void battlecry(string name)
        {
            Console.WriteLine(name + "!!!!");
            Thread.Sleep(1000);
        }
=======
        public abstract void battlecry();
>>>>>>> Opdracht2:Pokemon game/Pokemon_class.cs
    }
}