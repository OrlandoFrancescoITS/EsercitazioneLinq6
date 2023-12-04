using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq6
{
    internal class Automobile : Veicolo
    {
        public int NumeroPosti { get; set; }
        public Automobile(string targa, string modello, decimal tariffa, int numeroPosti) : base(targa, modello, tariffa)
        {
            NumeroPosti = numeroPosti;
        }
    }
}
