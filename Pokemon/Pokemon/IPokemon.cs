using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal interface IPokemon
    {
        public string Name { get; }
        public int Health { get; }

        public void LoosHealth(int dmg);
        
    }
}
