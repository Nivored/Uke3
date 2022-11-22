using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Game
    {
        public List<IPokemon> wildPokemon = new List<IPokemon>
        {
            new Pikachu(),
            new Lycanroc(), 
            new Gardevoir(),
        };

        Random random = new Random();

        private IPokemon GetRandomPokemon()
        {
            var randomIndex = random.Next(wildPokemon.Count);
            var randomPokemon = wildPokemon[randomIndex];
            return randomPokemon;
        }

        public void GetWildPokemon()
        {
            var magikarp = new Magikarp();
            var randomPokemon = GetRandomPokemon();

            while (true)
            {
                Console.WriteLine($"Pokemon: {randomPokemon.Name}! Health: {randomPokemon.Health}");
                Console.WriteLine($"Pokemon: {magikarp.Name}! Health: {magikarp.Health}");
                var userInput = Convert.ToInt32(Console.ReadLine());
                if (randomPokemon.Name == "Pikachu")
                {
                    if (GetPickachuFight(randomPokemon, userInput, magikarp)) return;
                }
                if (randomPokemon.Name == "Gardevoir")
                {
                    if (GetGardevoirFight(randomPokemon, userInput, magikarp)) return;
                }
                if (randomPokemon.Name == "Lycanroc")
                {
                    if (GetLycanrocFight(randomPokemon, userInput, magikarp)) return;
                }
            }
        }

        private static bool GetLycanrocFight(IPokemon randomPokemon, int userInput, Magikarp magikarp)
        {
            var lycanroc = randomPokemon as Lycanroc;
            if (userInput == 1) lycanroc.StoneEdge(magikarp);
            if (userInput == 2) lycanroc.EarthPower(magikarp);
            if (userInput == 3) lycanroc.BrickBreak(magikarp);
            if (userInput == 4) lycanroc.Crunch(magikarp);
            MagikarpIsHit(magikarp);
            if (MagikarpFaints(magikarp)) return true;
            magikarp.Splash(lycanroc);
            return false;
        }

        private static bool GetGardevoirFight(IPokemon randomPokemon, int userInput, Magikarp magikarp)
        {
            var gardevoir = randomPokemon as Gardevoir;
            if (userInput == 1) gardevoir.Psychic(magikarp);
            if (userInput == 2) gardevoir.DazzlingGleam(magikarp);
            if (userInput == 3) gardevoir.DrainingKiss(magikarp);
            if (userInput == 4) gardevoir.ShadowBall(magikarp);
            MagikarpIsHit(magikarp);
            if (MagikarpFaints(magikarp)) return true;
            magikarp.Splash(gardevoir);
            return false;
        }

        private static bool GetPickachuFight(IPokemon randomPokemon, int userInput, Magikarp magikarp)
        {
            var pikachu = randomPokemon as Pikachu;
            if (userInput == 1) pikachu.FocusPunch(magikarp);
            if (userInput == 2) pikachu.Thunder(magikarp);
            if (userInput == 3) pikachu.ThunderBolt(magikarp);
            if (userInput == 4) pikachu.IronTail(magikarp);
            MagikarpIsHit(magikarp);
            if (MagikarpFaints(magikarp)) return true;
            magikarp.Splash(pikachu);
            return false;
        }
        private static void MagikarpIsHit(Magikarp magikarp)
        {
            Console.WriteLine($"{magikarp.Name} was hit down to {magikarp.Health} health");
        }

        private static bool MagikarpFaints(Magikarp magikarp)
        {
            if (magikarp.Health <= 0)
            {
                Console.WriteLine($"{magikarp.Name} Fainted");
                return true;
            }
            return false;
        }
    }
}
