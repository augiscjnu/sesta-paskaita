using System;
using System.Collections.Generic;

namespace antrauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Preke> prekes = new List<Preke>();
            Console.WriteLine("Kiek prekių norite įvesti?");
            int prekiuKiekis = int.Parse(Console.ReadLine());

            for (int i = 0; i < prekiuKiekis; i++)
            {
                Console.WriteLine($"Įveskite {i + 1}-osios prekės pavadinimą:");
                string pavadinimas = Console.ReadLine();

                Console.WriteLine($"Įveskite {i + 1}-osios prekės kainą:");
                double kaina = double.Parse(Console.ReadLine());

                Console.WriteLine($"Įveskite {i + 1}-osios prekės kiekį:");
                int kiekis = int.Parse(Console.ReadLine());

                prekes.Add(new Preke { Pavadinimas = pavadinimas, Kaina = kaina, Kiekis = kiekis });
            }

            
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
