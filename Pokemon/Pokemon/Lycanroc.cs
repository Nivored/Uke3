using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Lycanroc : IPokemon
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Lycanroc()
        {
            Name = "Lycanroc";
            Health = 300;
        }

        public void LoosHealth(int dmg)
        {
            Health -= dmg;
        }

        public void StoneEdge(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Stone edge");
            opponent.LoosHealth(85);
        }

        public void Crunch(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Crunch");
            opponent.LoosHealth(80);
        }

        public void EarthPower(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Earth power");
            opponent.LoosHealth(90);
        }

        public void BrickBreak(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Brick break");
            opponent.LoosHealth(75);
        }
    }
}
