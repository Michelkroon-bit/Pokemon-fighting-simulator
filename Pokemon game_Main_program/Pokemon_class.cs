using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pokeball_class;
using Trainer_class;
using Pokemon_subclasses;
using Arena_class;
using battle_class;


/*notes
Abstract classes are like blueprints for other classes. You can't create an object directly from an abstract class, but you can create objects from classes that "inherit" from it. 
 */
namespace Pokemon_class;


public enum strengthlevels{Fire, Water, Grass}
public enum weaknesslevels{Fire, Water, Grass}
public abstract class Pokemon
    
{
  

    private string _naam { get;}

    private strengthlevels _strength;

    private weaknesslevels _weakness;
    private int _HP { get; set; }
    private int _Atk { get; set; }

    private string _attackname{ get; set; }

    public string Name => _naam;

    public string Nickname;
    public strengthlevels Strength => _strength;  
    public weaknesslevels Weakness => _weakness;

    public int hp => _HP;
    public int atk => _Atk;

    public string attackname => _attackname;
    public Pokemon(string naam, strengthlevels strength, weaknesslevels weakness, int HP, int Atk , string attackname)
    {
        _naam = naam;
        Nickname = Nickname;
        _strength = strength;
        _weakness = weakness;
        _HP = HP;
        _Atk = Atk;
        _attackname = attackname;
    }
    public abstract void battlecry();

}