using System;
using System.Collections.Generic;

namespace Libreria {
    class Libreria : List<Libro> {
        public void compraLibro() {
            Console.WriteLine("Antico (A) o Moderno(M)? ");
            switch (Console.ReadLine()) {
                case "A":
                    Add(new LibroAntico());
                    break;
                case "M":
                    Add(new LibroAttuale());
                    break;
                default:
                    Console.WriteLine("Guagliò, cosà staje facendò?");
                    break;
            }
        }

        public void illustraLibri() {
            int codice = 0;
            foreach (Libro l in this) {
                Console.WriteLine(Convert.ToString(codice++) + " " + l.Stampa() + "\n");
            }
        }

        public void vendiLibro() {
            if (Count == 0)
                Console.WriteLine("Libri terminati");
            else {
                illustraLibri();
                Console.WriteLine("Inserire il codice del libro desiderato");
                try {
                    RemoveAt(Convert.ToInt32(Console.ReadLine()));
                } catch (Exception) {
                    Console.WriteLine("CODICE ERRATO!!!");
                }
            }
        }
    }
}
