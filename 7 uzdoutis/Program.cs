using System;

namespace sesta
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kiek skaičių norite įvesti?");
            int skaičiųKiekis = int.Parse(Console.ReadLine());
            int[] skaičiai = new int[skaičiųKiekis];

          
            Console.WriteLine("Įveskite skaičius:");
            for (int i = 0; i < skaičiųKiekis; i++)
            {
                Console.Write($"Skaičius {i + 1}: ");
                skaičiai[i] = int.Parse(Console.ReadLine());
            }

            
            int suma = 0;
            bool neigiamasRastas = false;

            foreach (var skaičius in skaičiai)
            {
                if (skaičius < 0)
                {
                    neigiamasRastas = true;
                    break; 
                }
                suma += skaičius;
            }

           
            if (neigiamasRastas)
            {
                Console.WriteLine($"Suma iki pirmo neigiamo skaičiaus: {suma}");
            }
            else
            {
                Console.WriteLine($"Viso masyvo suma: {suma}");
            }
        }
    }
}
