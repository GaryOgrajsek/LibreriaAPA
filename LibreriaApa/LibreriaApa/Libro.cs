﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria {
    abstract class Libro {
        private string autore;
        private string titolo;
        private int annoPubblicazione;
        private decimal prezzoAcquisto;
        private decimal prezzoVendita;
        private int pezziPresenti;

        protected string Autore { get => autore; set => autore = value; }
        protected string Titolo { get => titolo; set => titolo = value; }
        protected int AnnoPubblicazione { get => annoPubblicazione; set => annoPubblicazione = value; }
        protected decimal PrezzoAcquisto { get => prezzoAcquisto; set => prezzoAcquisto = value; }
        protected decimal PrezzoVendita { get => prezzoVendita; set => prezzoVendita = value; }
        protected int PezziPresenti { get => pezziPresenti; set => pezziPresenti = value; }

        public Libro(/*string a, string t, int an, decimal pA, decimal pV, int p*/) {
            /*this.Autore = a;
            this.Titolo = t;
            this.AnnoPubblicazione = an;
            this.PrezzoAcquisto = pA;
            this.PrezzoVendita = pV;
            this.PezziPresenti = p;*/
        }

        public virtual string Stampa() {
            return Autore + "|" + Titolo + "|" + AnnoPubblicazione + "|" + PrezzoAcquisto + "|" + PrezzoVendita + "|" + pezziPresenti + "|";
        }

        public virtual void Modifica() {
            string tmp = "";

            Console.WriteLine("Autore ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                Autore = tmp;
            }

            Console.WriteLine("Titolo ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                Titolo = tmp;
            }

            Console.WriteLine("Anno pubblicazione ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                AnnoPubblicazione = Convert.ToInt32(tmp);
            }

            Console.WriteLine("Prezzo acquisto ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                PrezzoAcquisto = Convert.ToDecimal(tmp);
            }

            Console.WriteLine("Prezzo vendita ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                PrezzoVendita = Convert.ToDecimal(tmp);
            }

            Console.WriteLine("Pezzi presenti ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                PezziPresenti = Convert.ToInt32(tmp);
            }
        }
    }
}