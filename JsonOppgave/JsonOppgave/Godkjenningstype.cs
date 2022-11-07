using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOppgave
{
    public class Godkjenningstype
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Godkjenningstype(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
