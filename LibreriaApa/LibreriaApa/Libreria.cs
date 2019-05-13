using System;

namespace Libreria {
    class Libreria : List<Libro> {
        public void compraLibro() {
            Console.WriteLine("Antico (A) o Moderno(M)? ");
            switch (Console.ReadLine()) {
                case "A":
                    LibroAntico tmp = new LibroAntico();
                    tmp.Modifica();
                    Add(tmp);
                    break;
                case "M":
                    LibroAttuale tmpa = new LibroAttuale();
                    tmpa.Modifica();
                    Add(tmpa);
                    break;
                default:
                    Console.WriteLine("Guagliò, cosà staje facendò?");
                    break;
            }
        }

        public void illustraLibri() {
            int codice = 0;
            foreach (Libro l in this) {
                Console.WriteLine(Convert.ToString(codice) + " " + l.Stampa() + "\n");
                codice++;
            }
        }

        public void vendiLibro() {
            if (Count == 0) {
                Console.WriteLine("Libri terminati");
            } else {
                illustraLibri();
                Console.WriteLine("Inserire il codice del libro desiderato");
                try {
                    RemoveAt(Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception) {
                    Console.WriteLine("CODICE ERRATO!!!");
                }
            }
        }
    }
}
