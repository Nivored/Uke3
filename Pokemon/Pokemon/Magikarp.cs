using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Magikarp : IPokemon
    {
        public int Health { get; private set; }
        public bool IsUsless { get; private set; }
        public string Name { get; private set; }

        public Magikarp()
        {
            Name = "Magikarp";
            Health = 120;
        }

        public void LoosHealth(int dmg)
        {
            Health -= dmg;
        }

        public void Splash(IPokemon opponent)
        {
            Console.WriteLine($"{Name} used Splash");
            opponent.LoosHealth(0);
            Console.WriteLine($"{Name} is flopping around");
        }
    }
}
