using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace JsonOppgave
{
    public class VerkstedControll
    {
        public VerkstedControll()
        {
            var fileName = $"verkstedfil.json";
            var jsonString = File.ReadAllText(fileName);
            verkstedList = JsonSerializer.Deserialize<List<Verksted>>(jsonString)!;
        }

        public List<Verksted> verkstedList = new List<Verksted>();

        public List<Komuner> komuneList = new List<Komuner>()
        {
            new Komuner("Oslo", 1) { PostNrFra = 0001, PostNrTil = 1299 },
            new Komuner("Akershus", 2) { PostNrFra = 1300, PostNrTil = 1499 },
            new Komuner("Akershus", 2) { PostNrFra = 1900, PostNrTil = 2099 },
            new Komuner("Østfold", 3) { PostNrFra = 1500, PostNrTil = 1899 },
            new Komuner("Hedmark", 4) { PostNrFra = 2100, PostNrTil = 2599 },
            new Komuner("Oppland", 5) { PostNrFra = 2600, PostNrTil = 2899},
            new Komuner("Oppland", 5) { PostNrFra = 3500, PostNrTil = 3599},
            new Komuner("Buskerud", 6){ PostNrFra = 3000, PostNrTil = 3050},
            new Komuner("Buskerud", 6){ PostNrFra = 3300, PostNrTil = 3499},
            new Komuner("Vestfold", 7){ PostNrFra = 3051, PostNrTil = 3299},
            new Komuner("Telemark", 8){ PostNrFra = 3600, PostNrTil = 3999},
            new Komuner("Rogaland", 9){ PostNrFra = 4000, PostNrTil = 4450},
            new Komuner("Rogaland", 9){ PostNrFra = 5500, PostNrTil = 5599},
            new Komuner("Vest-Agder", 10){ PostNrFra = 4451, PostNrTil = 4750},
            new Komuner("Aust-Agder", 11){ PostNrFra = 4751, PostNrTil = 4999},
            new Komuner("Hordaland", 12){ PostNrFra = 5000, PostNrTil = 5499},
            new Komuner("Hordaland", 12){ PostNrFra = 5551, PostNrTil = 5750},
            new Komuner("Hordaland", 12){ PostNrFra = 5800, PostNrTil = 5950},
            new Komuner("Sogn og Fjordane", 13){ PostNrFra = 5751, PostNrTil = 5799},
            new Komuner("Sogn og Fjordane", 13){ PostNrFra = 5951, PostNrTil = 5999},
            new Komuner("Sogn og Fjordane", 13){ PostNrFra = 6700, PostNrTil = 6999},
            new Komuner("Møre og Romsdal", 14){ PostNrFra = 6000, PostNrTil = 6699},
            new Komuner("Sør Trøndelag", 15){ PostNrFra = 7000, PostNrTil = 7550},
            new Komuner("Sør Trøndelag", 15){ PostNrFra = 7700, PostNrTil = 7950},
            new Komuner("Nord Trøndelag", 16){ PostNrFra = 7551, PostNrTil = 7699},
            new Komuner("Nord Trøndelag", 16){ PostNrFra = 7751, PostNrTil = 7950},
            new Komuner("Norland", 17){ PostNrFra = 7951, PostNrTil = 8450},
            new Komuner("Norland", 17){ PostNrFra = 8500, PostNrTil = 8999},
            new Komuner("Troms", 18){ PostNrFra = 8451, PostNrTil = 8499},
            new Komuner("Troms", 18){ PostNrFra = 9000, PostNrTil = 9150},
            new Komuner("Troms", 18){ PostNrFra = 9200, PostNrTil = 9499},
            new Komuner("Finnmark", 19){ PostNrFra = 9151, PostNrTil = 9199},
            new Komuner("Finnmark", 19){ PostNrFra = 9500, PostNrTil = 9999},
        };

        public List<Godkjenningstype> godkjenningstype = new List<Godkjenningstype>()
        {
            new Godkjenningstype("Bilverksted01", 1),
            new Godkjenningstype("Bilverksted01b", 2),
            new Godkjenningstype("Bilverksted02", 3),
            new Godkjenningstype("Bilverksted03", 4),
            new Godkjenningstype("Kontrollorgan01", 5),
            new Godkjenningstype("Kontrollorgan01b", 6),
            new Godkjenningstype("Kontrollorgan02", 7),
            new Godkjenningstype("Kontrollorgan03", 8),
            new Godkjenningstype("Kontrollorgan04", 9),
            new Godkjenningstype("Kontrollorgan05", 10),
            new Godkjenningstype("Skadeverksted01", 11),
            new Godkjenningstype("Skadeverksted02", 12),
            new Godkjenningstype("Bilskade", 13),
            new Godkjenningstype("Hengerespalopsbremseanlegg", 14),
            new Godkjenningstype("Bilelektrodrivstoffanlegg", 15),
            new Godkjenningstype("Bilverkstedalle", 16),
            new Godkjenningstype("Eksosanlegg", 17),
            new Godkjenningstype("Hjul", 18),
            new Godkjenningstype("Hjulutrustning", 19),
            new Godkjenningstype("Bilbremse", 20),
            new Godkjenningstype("Bilglass", 21),
            new Godkjenningstype("Bildiesel", 22),
            new Godkjenningstype("Gassdriftanlegg", 23),
            new Godkjenningstype("Lysutstyr", 24),
            new Godkjenningstype("Alkolasverksted", 25),
            new Godkjenningstype("Pabygger", 26),
            new Godkjenningstype("Fartsskriver", 27),
            new Godkjenningstype("Motorsykkelogmoped", 28),
            new Godkjenningstype("Traktor", 29),
        };

        public void PrintKomune()
        {
            var printedOutNames = new List<string>();

            foreach (var county in komuneList)
            {
                if (printedOutNames.Contains(county.Navn)) continue;
                Console.WriteLine($"{county.KomuneNr}: {county.Navn}");
                printedOutNames.Add(county.Navn);
            }
        }

        public void PrintGodkjenninger()
        {
            foreach (var godkjenning in godkjenningstype)
            {
                Console.WriteLine($"{godkjenning.Id}: {godkjenning.Name}");
            }
        }

        public void KomuneValg()
        {
            var input = Convert.ToInt32(Console.ReadLine());
            var valgtKomune = komuneList.Where(komune => komune.KomuneNr == input);

            foreach (var komune in valgtKomune)
            {
                foreach (var verksted in verkstedList)
                {
                    int postnummer = int.Parse(verksted.Postnummer);
                    if (postnummer >= komune.PostNrFra && postnummer <= komune.PostNrTil)
                    {
                        verksted.PrintVerksted();
                    }
                }
            }
        }

        public void GodkjenningsValg()
        {
            var input = Convert.ToInt32(Console.ReadLine());

            var valgtGodkjenning = godkjenningstype.FindAll(godkjenningstype => godkjenningstype.Id == input);

            foreach (var godkjenning in valgtGodkjenning)
            {
                foreach (var verksted in verkstedList)
                {
                    if (verksted.Godkjenningstyper.ToLower().Contains(godkjenning.Name.ToLower()))
                    {
                        verksted.PrintVerksted();
                    }
                }
            }
        }
    }
}
