using System;
using System.Text;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Pokemon_battle_simulator;

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine(@"                                  
                                  ,'\
    _.----.        ____         ,'  _\   ___    ___     ____
_,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
\      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
 \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
   \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
    \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
     \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
      \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
       \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
        \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                `'                            '-._|",Console.ForegroundColor);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Hello traveler welcome to the pokemon battle simulator" , Console.ForegroundColor);
Console.WriteLine("Press enter to continue... ");
Console.ReadKey();

Console.Write("Trainer 1, please enter your username: ");
string trainerName1 = Console.ReadLine();
var trainer1 = new trainer(trainerName1);

Console.Write("Trainer 2, please enter your username: ");
string trainerName2 = Console.ReadLine();
var trainer2 = new trainer(trainerName2);


void NamePokemons(trainer trainer)
{
    Console.WriteLine(trainer.name + ", please give names to your pokemons:");
    for (int i = 0; i < trainer.belt.Count; i++)  
    {
        var currentpokemon = trainer.belt[i].ContainedPokemon;

        Console.WriteLine(currentpokemon.GetType().Name+ " #"+i + " ,give it a name:");
        string pokemonName = Console.ReadLine();

        currentpokemon.naam = pokemonName;
        Console.WriteLine("Your"+ currentpokemon.GetType().Name +"#" + i + " is now named: " + currentpokemon.naam);

    }
};

NamePokemons(trainer1);
NamePokemons(trainer2);

Battle battle = new Battle(trainer1, trainer2);

