using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria {
    class LibroAttuale : Libro {
        private int numeroPagine;
        private string casaEditrice;
        private Int64 isbn;

        public int NumeroPagine { get => numeroPagine; set => numeroPagine = value; }
        public string CasaEditrice { get => casaEditrice; set => casaEditrice = value; }
        public Int64 Isbn { get => isbn; set => isbn = value; }

        public LibroAttuale(/*string a, string t, int an, decimal pA, decimal pV, int p, int n, string c, int i) : base(a, t, an, pA, pV, p*/) {
            /*this.NumeroPagine = n;
            this.CasaEditrice = c;
            this.Isbn = i;*/
        }

        public override string Stampa() {
            return base.Stampa() + NumeroPagine + "|" + CasaEditrice + "|" + Isbn;
        }

        public override void Modifica() {
            base.Modifica();

            string tmp = "";

            Console.WriteLine("Numero pagine ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                NumeroPagine = Convert.ToInt32(tmp);
            }

            Console.WriteLine("Casa editrice ");
            tmp = Console.ReadLine();
            if (tmp != "\r") {
                CasaEditrice = tmp;
            }
        }
    }
}