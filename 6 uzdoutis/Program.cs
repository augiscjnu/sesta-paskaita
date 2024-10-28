using System;

namespace sesta
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            double[] temperatūros = new double[7];

           
            Console.WriteLine("Įveskite 7 dienu temperaturas:");
            for (int i = 0; i < temperatūros.Length; i++)
            {
                Console.Write($"Temperatūra dienai {i + 1}: ");
                temperatūros[i] = double.Parse(Console.ReadLine());
            }

           
            double aukščiausiaTemperatūra = temperatūros[0];
            for (int i = 1; i < temperatūros.Length; i++)
            {
                if (temperatūros[i] > aukščiausiaTemperatūra)
                {
                    aukščiausiaTemperatūra = temperatūros[i];
                }
            }

            
            double suma = 0;
            foreach (var temp in temperatūros)
            {
                suma += temp;
            }
            double vidurkis = suma / temperatūros.Length;

            
            Console.WriteLine($"\nAukščiausia savaitės temperatūra: {aukščiausiaTemperatūra}");

            
            if (vidurkis < 10)
            {
                Console.WriteLine("Savaitės temperatūros vidurkis yra mažesnis nei 10.");
            }
        }
    }
}
