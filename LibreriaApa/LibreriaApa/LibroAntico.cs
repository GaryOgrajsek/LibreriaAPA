using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria {
    class LibroAntico : Libro {
        private string nomeVenditore;
        private string nomeCompratore;
        private string descrizione;
        private int codice;

        public string NomeVenditore { get => nomeVenditore; set => nomeVenditore = value; }
        public string NomeCompratore { get => nomeCompratore; set => nomeCompratore = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public int Codice { get => codice; set => codice = value; }

        public LibroAntico() {}

        public override string Stampa() {
            return base.Stampa() + NomeVenditore + "|" + NomeCompratore + "|" + Descrizione;
        }

        public override void Modifica() {
            base.Modifica();

            string tmp = "";

            Console.WriteLine("Nome venditore ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                NomeVenditore = tmp;
            }

            Console.WriteLine("Nome compratore ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                NomeCompratore = tmp;
            }

            Console.WriteLine("Descrizione ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                Descrizione = tmp;
            }
        }
    }
}
