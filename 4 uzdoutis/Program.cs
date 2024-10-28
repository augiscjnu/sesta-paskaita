using System;
using System.Collections.Generic;

namespace penktauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            List<Preke> prekes = new List<Preke>
            {
                new Preke { Pavadinimas = "Obuolys", Kaina = 1.50, Kiekis = 5 },
                new Preke { Pavadinimas = "Pienas", Kaina = 0.99, Kiekis = 10 },
                new Preke { Pavadinimas = "Duona", Kaina = 1.20, Kiekis = 3 },
                new Preke { Pavadinimas = "Sūris", Kaina = 2.50, Kiekis = 4 },
                new Preke { Pavadinimas = "Mėsa", Kaina = 5.00, Kiekis = 2 }
            };

            
            double bendraSuma = 0;
            foreach (var preke in prekes)
            {
                bendraSuma += preke.BendraKaina();
            }

            
            Console.WriteLine($"Bendra kaina: {bendraSuma}");

            
            if (bendraSuma > 50)
            {
                Console.WriteLine("Krepšelio suma viršija 50.");
            }
            else
            {
                Console.WriteLine("Krepšelio suma yra 50 arba mažiau.");
            }
        }
    }
}
