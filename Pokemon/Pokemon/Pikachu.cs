using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Pikachu : IPokemon
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Pikachu()
        {
            Name = "Pikachu";
            Health = 200;
        }

        public void LoosHealth(int dmg)
        {
            Health -= dmg;
        }

        public void IronTail(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Iron tail");
            opponent.LoosHealth(75);
        }

        public void ThunderBolt(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Thunderbolt");
            opponent.LoosHealth(85);
        }

        public void Thunder(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Thunder");
            opponent.LoosHealth(120);
        }

        public void FocusPunch(IPokemon opponent)
        {
            Console.WriteLine("Pikachu used Focus punch");
            opponent.LoosHealth(70);
        }
    }
}
