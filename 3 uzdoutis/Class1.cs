namespace trecia
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public int[] Pazymiai { get; set; }

        public double Vidurkis()
        {
            if (Pazymiai.Length == 0) return 0;

            double suma = 0;
            foreach (int pazymys in Pazymiai)
            {
                suma += pazymys;
            }
            return suma / Pazymiai.Length;
        }

        public bool Islaike()
        {
            return Vidurkis() >= 5;
        }
    }
}
