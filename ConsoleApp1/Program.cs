using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autovetture auto1 = new Autovetture();
            auto1.Marca = "Ford";

            Autovetture auto2 = new Autovetture();
            auto2.Marca = "Mercedes";

            Console.WriteLine("Auto1: " + auto1.Marca);
            Console.WriteLine("\n");
            Console.WriteLine("Auto2: " + auto2.Marca);
            Console.WriteLine("\n");

            auto1.Marca = "Ferrari";
            Console.WriteLine("Auto1 aggiornata: " + auto1.Marca);
            Console.WriteLine("\n");

            string Messaggio = auto1.kmTagliando(500);
            Console.WriteLine(Messaggio);
            Console.WriteLine("\n");

            string altroMessaggio = auto2.kmTagliando(15000);
            Console.WriteLine(altroMessaggio);
            Console.WriteLine("\n");

            Atleta atleta1 = new Atleta();
            atleta1.Nome = "Francesco";
            string velocita1 = atleta1.kmOrari(120);
            Console.WriteLine(atleta1.Nome + " " + velocita1);
            Atleta atleta2 = new Atleta();
            string velocita2 = atleta2.kmOrari(30);
            atleta2.Nome = "Egidio";
            Console.WriteLine("\n");
            Console.WriteLine(atleta2.Nome + " " + velocita2);
            Console.WriteLine("\n");

            Animale animale1 = new Animale();
            animale1.Razza = "Cane";
            Console.WriteLine("Razza: " +  animale1.Razza);
            Animale animale2  = new Animale();
            animale2.Razza = "Gatto";
            Console.WriteLine("\n");
            Console.WriteLine("Razza: " + animale2.Razza);
            Console.WriteLine("\n");

            Dipendente dipendente1 = new Dipendente();
            dipendente1.Nome = "Melissa";
            dipendente1.Cognome = "Canu";
            string elogio = dipendente1.messaggio(dipendente1.Cognome);
            Console.WriteLine("Dipendente: " + dipendente1.Nome + " " + dipendente1.Cognome + elogio);
            Console.WriteLine("\n");
            Dipendente dipendente2 = new Dipendente();
            dipendente2.Nome = "Egidio";
            dipendente2.Cognome = "Roseti";
            string elogio2 = dipendente2.messaggio(dipendente2.Cognome);
            Console.WriteLine("Dipendente: " + dipendente2.Nome + " " + dipendente2.Cognome + elogio2);

            Console.ReadLine();
        }
    }
}
