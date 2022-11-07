using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Gardevoir : IPokemon
    {
        public string Name { get; private set; }
        public int Health { get; private set; }


        public Gardevoir()
        {
            Name = "Gardevoir";
            Health = 250;
        }

        public void LoosHealth(int dmg)
        {
            Health -= dmg;
        }

        public void Psychic(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Psychic");
            opponent.LoosHealth(80);
        }

        public void DrainingKiss(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Draining kiss");
            opponent.LoosHealth(75);
        }

        public void DazzlingGleam(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Dazzling gleam");
            opponent.LoosHealth(80);
        }

        public void ShadowBall(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Shadow ball");
            opponent.LoosHealth(80);
        }
    }
}
