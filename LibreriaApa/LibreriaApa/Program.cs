﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaApa {
    class Program {
        static void Main(string[] args) {
            Libreria.Libreria l = new Libreria.Libreria();
            while (true) {
                Console.WriteLine("Vendi V Compra C");
                switch (Console.ReadLine()) {
                    case "V":
                        l.vendiLibro();
                        break;
                    case "C":
                        l.compraLibro();
                        break;
                    default:
                        Console.WriteLine("NO");
                        break;
                }
            }
        }
    }
}
