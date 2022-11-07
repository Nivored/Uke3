using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Game
    {
        public List<IPokemon> wildPokemon { get; set; }

        public Game()
        {
            wildPokemon = new List<IPokemon>
            {
                new Pikachu(),
                new Lycanroc(),
                new Gardevoir(),
            };
        }

        public void GetWildPokemon()
        {
            Random random = new Random();
            var magikarp = new Magikarp();

            var randomIndex = random.Next(wildPokemon.Count);
            var randomPokemon = wildPokemon[randomIndex];

            while (true)
            {
                Console.WriteLine($"Pokemon: {randomPokemon.Name}! Health: {randomPokemon.Health}");
                Console.WriteLine($"Pokemon: {magikarp.Name}! Health: {magikarp.Health}");
                var userInput = Convert.ToInt32(Console.ReadLine());
                if (randomPokemon.Name == "Pikachu")
                {
                    var pikachu = randomPokemon as Pikachu;
                    if (userInput == 1) pikachu.FocusPunch(magikarp);
                    if (userInput == 2) pikachu.Thunder(magikarp);
                    if (userInput == 3) pikachu.ThunderBolt(magikarp);
                    if (userInput == 4) pikachu.IronTail(magikarp);
                    Console.WriteLine($"{magikarp.Name} was hit down to {magikarp.Health} health");
                    if (magikarp.Health < 0)
                    {
                        Console.WriteLine($"{magikarp.Name} Fainted");
                        return;
                    }
                    magikarp.Spalsh(pikachu);
                }

                if (randomPokemon.Name == "Gardevoir")
                {
                    var gardevoir = randomPokemon as Gardevoir;
                    if (userInput == 1) gardevoir.Psychic(magikarp);
                    if (userInput == 2) gardevoir.DazzlingGleam(magikarp);
                    if (userInput == 3) gardevoir.DrainingKiss(magikarp);
                    if (userInput == 4) gardevoir.ShadowBall(magikarp);
                    Console.WriteLine($"{magikarp.Name} was hit down to {magikarp.Health} health");
                    if (magikarp.Health < 0)
                    {
                        Console.WriteLine($"{magikarp.Name} Fainted");
                        return;
                    }
                    magikarp.Spalsh(gardevoir);
                }

                if (randomPokemon.Name == "Lycanroc")
                {
                    var lycanroc = randomPokemon as Lycanroc;
                    if (userInput == 1) lycanroc.StoneEdge(magikarp);
                    if (userInput == 2) lycanroc.EarthPower(magikarp);
                    if (userInput == 3) lycanroc.BrickBreak(magikarp);
                    if (userInput == 4) lycanroc.Crunch(magikarp);
                    Console.WriteLine($"{magikarp.Name} was hit down to {magikarp.Health} health");
                    if (magikarp.Health < 0)
                    {
                        Console.WriteLine($"{magikarp.Name} Fainted");
                        return;
                    }
                    magikarp.Spalsh(lycanroc);
                }
            }
        }
    }
}
