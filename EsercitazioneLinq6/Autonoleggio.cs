using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq6
{
    internal class Autonoleggio
    {
        public List<Noleggio> Noleggi { get; set; } = new List<Noleggio>();
        /*List<Cliente> Clienti { get; set; } = new List<Cliente>();    
        List<Veicolo> Veicoli { get; set; } = new List<Veicolo>();*/

        public void MostraNoleggi(string info)
        {
            List<Noleggio> noleggiTrovati = new List<Noleggio>();
            noleggiTrovati = Noleggi.FindAll(x => x.Cliente.CodiceFiscale == info);
            noleggiTrovati.ForEach(x => Console.WriteLine($"{x.Veicolo.ToString()} {x.NumeroGiorni}\n{x.Cliente.ToString()}" +
                $"\nCosto: {x.Costo}\nData di inizio: {x.DataInizio.ToString("dd/MM/yyyy")}"));
            noleggiTrovati = Noleggi.FindAll(x => x.Veicolo.Targa == info);
            noleggiTrovati.ForEach(x => Console.WriteLine($"{x.Veicolo.ToString()} {x.NumeroGiorni}\n{x.Cliente.ToString()}" +
                $"\nCosto: {x.Costo}\nData di inizio: {x.DataInizio.ToString("dd/MM/yyyy")}"));
        }

        public void AggiungiNoleggio(Noleggio noleggio)
        {
            Noleggio n = Noleggi.Find(x => x == noleggio);
            if (n == null)
            {
                Noleggi.Add(noleggio);
                string path = @"C:\Users\franc\VisualStudioProjects\EsercitazioneLinq6\EsercitazioneLinq6\nuoviNoleggi.txt";
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(noleggio.ToString());
                    fs.Write(info, 0, info.Length);
                }
            }
        }

        public void TotaleNoleggiTarga(string targa)
        {
            Decimal totale = 0;
            List<Noleggio> n = Noleggi.FindAll(x => x.Veicolo.Targa == targa);
            n.ForEach(x => totale += x.NumeroGiorni * x.Veicolo.Tariffa);
            Console.WriteLine($"Totale: {totale}");
        }
        public void TotaleNoleggiCF(string codiceFiscale)
        {
            Decimal totale = 0;
            List<Noleggio> n = Noleggi.FindAll(x => x.Cliente.CodiceFiscale == codiceFiscale);
            n.ForEach(x => totale += x.NumeroGiorni * x.Veicolo.Tariffa);
            Console.WriteLine($"Totale: {totale}");
        }
        public void TotaleNoleggiModello(string modello)
        {
            Decimal totale = 0;
            List<Noleggio> n = Noleggi.FindAll(x => x.Veicolo.Modello == modello);
            n.ForEach(x => totale += x.NumeroGiorni * x.Veicolo.Tariffa);
            Console.WriteLine($"Totale: {totale}");
        }
    }
}
