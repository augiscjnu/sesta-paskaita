using System;

namespace penktauzdoutis
{
    public class Preke
    {
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
        public int Kiekis { get; set; }

        public double BendraKaina()
        {
            return Kaina * Kiekis;
        }
    }
}
