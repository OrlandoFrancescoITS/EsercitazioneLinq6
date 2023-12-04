using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq6
{
    internal class Furgone : Veicolo
    {
        public double Capacita { get; set; }
        public Furgone(string targa, string modello, decimal tariffa, double capacita) : base(targa, modello, tariffa)
        {
            Capacita = capacita;
        }
    }
}
