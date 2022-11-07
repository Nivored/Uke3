using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonOppgave
{
    public class Verksted
    {
        private readonly string _postNumber;

        public string? Bedriftsnavn { get; set; }
        public string? Adresse { get; set; }
        public dynamic? Postnummer
        {
            get => _postNumber;
            init => _postNumber = value?.ToString();
        }
        public string? Poststed { get; set; }
        public string? Godkjenningstyper { get; set; }
        public int Organisasjonsnummer { get; set; }
        public int Godkjenningsnummer { get; set; }

        private List<Verksted> godkjenninger { get; set; }

        public void PrintVerksted()
        {
            Console.WriteLine($"{Bedriftsnavn}");
            Console.WriteLine($"{Postnummer}");
            Console.WriteLine($"{Poststed}");
            Console.WriteLine($"{Godkjenningstyper} \n");
        }

        public void PrintGodkjenninger()
        {
            foreach (var godkjenning in godkjenninger)
            {
                Console.WriteLine($"{godkjenning.Godkjenningstyper}");
            }
        }

        public void AddGodkjenning(Verksted godkjenningToAdd)
        {
            godkjenninger.Add(godkjenningToAdd);
        }
    }
}
