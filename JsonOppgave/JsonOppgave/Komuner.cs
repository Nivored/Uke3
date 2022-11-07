using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonOppgave
{
    public class Komuner
    {
        public string Navn { get; private set; }
        public int KomuneNr { get; private set; }
        public int PostNrFra { get; set; }
        public int PostNrTil { get; set; }

        public Komuner(string navn, int komuneNr)
        {
            Navn = navn;
            KomuneNr = komuneNr;
        }

    }
}
