using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneLinq6
{
    internal class Cliente
    {
        public string CodiceFiscale { get; set; }
        public String Nome { get; set; }
        public string Cognome { get; set; }

        public Cliente(string codiceFiscale, string nome, string cognome)
        {
            CodiceFiscale = codiceFiscale;
            Nome = nome;
            Cognome = cognome;
        }

        public override string ToString()
        {
            return $"Codicefiscale: {CodiceFiscale}\nNome: {Nome}\nCognome: {Cognome}";
        }
    }
}
