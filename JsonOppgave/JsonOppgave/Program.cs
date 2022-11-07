namespace JsonOppgave
{
    internal class Program
    {
        private static VerkstedControll verkstedControll = new VerkstedControll();
        private static Verksted verkste = new Verksted();
        static void Main(string[] args)
        {
            while (true)
            {
                MainMenu();
            }
        }

        static void MainMenu()
        {
            Console.WriteLine("1: Søk på Fylke ");
            Console.WriteLine("2: søk på godkjenningsnummer");
            Console.WriteLine("0: Avslutt");
            MenuInputs();
        }


        static void MenuInputs()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    verkstedControll.PrintKomune();
                    verkstedControll.KomuneValg();
                    break;
                case "2":
                    Console.WriteLine("Velg godkjenningstype");
                    verkstedControll.PrintGodkjenninger();
                    verkstedControll.GodkjenningsValg();
                    break;
            }
        }

    }
}