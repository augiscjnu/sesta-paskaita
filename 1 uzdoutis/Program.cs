using System;

namespace pirmauzdoutis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių masyvą, atskirtą tarpu (pvz., 1 2 -3 0):");
            string i = Console.ReadLine();
            string[] s = i.Split(' ');
            int[] n = Array.ConvertAll(s, int.Parse);

            int max = n[0];
            int min = n[0];
            int p = 0;
            int ne = 0;
            int z = 0;
            bool h = false;

            foreach (int number in n)
            {
               
                if (number > max) max = number;
                if (number < min) min = number;

                
                if (number > 0) p++;
                else if (number < 0) ne++;
                else z++;

                
                if (number % 2 == 0)
                {
                    h = true;
                }
            }

            
            Console.WriteLine($"Didžiausias skaičius: {max}");
            Console.WriteLine($"Mažiausias skaičius: {min}");
            Console.WriteLine($"Teigiamų skaičių: {p}");
            Console.WriteLine($"Neigiamų skaičių: {ne}");
            Console.WriteLine($"Nulių skaičius: {z}");

            if (h)
            {
                Console.WriteLine("Masyve yra lyginių skaičių.");
            }
            else
            {
                Console.WriteLine("Masyve nėra lyginių skaičių.");
            }
        }
    }
}
