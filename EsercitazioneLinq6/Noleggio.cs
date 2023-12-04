using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq6
{
    internal class Noleggio
    {
        public int ID { get; set; }
        public DateTime DataInizio { get; set; }
        public int NumeroGiorni { get; set; }
        public Decimal Costo { get; set; }
        public Cliente Cliente { get; set; }
        public Veicolo Veicolo { get; set; }

        public Noleggio(int iD, DateTime dataInizio, int numeroGiorni, Cliente cliente, Veicolo veicolo)
        {
            ID = iD;
            DataInizio = dataInizio;
            NumeroGiorni = numeroGiorni;
            //Costo = costo;
            Cliente = cliente;
            Veicolo = veicolo;
        }

        public override string ToString()
        {
            return $"id: {ID}\nData di inizio: {DataInizio.ToString("dd/MM/yyyy")}\nNumero giorni: {NumeroGiorni}\nCosto: {Costo}\n{Cliente.ToString()}\n{Veicolo.ToString()}";
        }

        public void CostoNoleggio()
        {
            Console.WriteLine(Veicolo.Tariffa * NumeroGiorni);
        }
    }
}
