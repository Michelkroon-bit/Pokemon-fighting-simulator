using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Pokemons;

Console.WriteLine("Hello traveler welcome to the pokemon battle simulator");
Console.WriteLine("Press enter to continue... ");
Console.ReadKey();
var Charmander = new Pokemon("Charmander", "Fire", "Water", 10, 4);


Console.WriteLine("your have caught a new pokemon its a " + Charmander.naam);
Console.WriteLine("Press enter to continue... ");
Console.ReadKey();

while (true)
{
    Charmander.naam = "Charmander";
    Console.WriteLine("Let's Give your " + Charmander.naam + " a name: ");
    String Pokemon_naam = Console.ReadLine();
    Console.WriteLine("Press enter to continue... ");
    Charmander.naam = Pokemon_naam;
    Console.ReadKey();
    Console.WriteLine(Charmander.naam + " Thats a great name you picked there");


    Console.WriteLine("Your pokemon does 10 battle cries");
    for (int i = 1; i < 11; i++)
    {
        Pokemon.battlecry(Charmander.naam);
    }


    Console.WriteLine("Press enter to rename your pokemon or type 'X' to quit");
    string input = Console.ReadLine();

    if (input.ToUpper() == "X")
    {
        Console.WriteLine("Thanks for playing :)");
        break;
    }
};
