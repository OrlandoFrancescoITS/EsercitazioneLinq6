using System.Text;

namespace EsercitazioneLinq6
{
    internal class Veicolo
    {
        public string Targa { get; set; }
        public string Modello { get; set; }
        public decimal Tariffa { get; set; }
        public Veicolo(string targa, string modello, decimal tariffa)
        {
            Targa = targa;
            Modello = modello;
            Tariffa = tariffa;
        }

        public override string ToString()
        {
            return $"Targa: {Targa}\nModello: {Modello}\nTariffa: {Tariffa}";
        }
    }
}
