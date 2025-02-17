using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Pokemons;

//var Charmander = new Pokemon("Testing", "Water", "Fire" ,15 , 7); buggy af
/*
4. The player can give a new name to the same charmander. ja isg

6. Repeat 4 and 5 until the player quits the game.
 */


    //1. The player start the game.
    Console.WriteLine("Hello traveler welcome to the pokemon battle simulator");
    Console.WriteLine("Press enter to continue... ");
    Console.ReadKey();

    var defaultName = "Charmander"; 
    var pokemon = new Pokemon(defaultName, "Fire", "Water", 10, 4);
//2.The player gives a name to a charmander.
Console.WriteLine("your have caught a new pokemon its a " + Weedle.naam);
    Console.WriteLine("Press enter to continue... ");
    Console.ReadKey();

while(true)
{
    Console.WriteLine("Let's Give your "+ pokemon.naam + " a name: ");
    String Pokemon_naam = Console.ReadLine();
    Console.WriteLine("Press enter to continue... ");
    pokemon.naam = Pokemon_naam;
    Console.ReadKey();
    Console.WriteLine(pokemon.naam+" Thats a great name you picked there");

    //3. The charmander does its battle cry for ten times. 
    //5. The charmander does its battle cry for ten times.

    Console.WriteLine("Your pokemon does 10 battle cries");
    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine("Battle cry #" + i + "!!!!");
    }
    Console.WriteLine("Press enter to rename your pokemon or type 'X' to quit");
    string input = Console.ReadLine();

    if (input.ToUpper() == "X")
    {
        Console.WriteLine("Thanks for playing :)");
        break;
    }

    var defaultName = "Charmander";
};
