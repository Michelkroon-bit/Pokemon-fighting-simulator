using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    public class Pokemon
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
        public static void battlecry(string name)
        {
            Console.WriteLine(name + "!!!!");
            Thread.Sleep(1000);
        }
    }
}

