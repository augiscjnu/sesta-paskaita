

namespace penkta
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] skaičiai = new int[10];
            List<int> didesniUž20 = new List<int>();
            int neigiamųSkaičiųKiekis = 0;

            
            Console.WriteLine("Įveskite 10 skaičių:");
            for (int i = 0; i < skaičiai.Length; i++)
            {
                Console.Write($"Skaičius {i + 1}: ");
                skaičiai[i] = int.Parse(Console.ReadLine());

                
                if (skaičiai[i] > 20)
                {
                    didesniUž20.Add(skaičiai[i]);
                }

                
                if (skaičiai[i] < 0)
                {
                    neigiamųSkaičiųKiekis++;
                }
            }

            
            Console.WriteLine("\nSkaičiai, didesni už 20:");
            foreach (var skaičius in didesniUž20)
            {
                Console.WriteLine(skaičius);
            }

            Console.WriteLine($"\nNeigiamų skaičių kiekis: {neigiamųSkaičiųKiekis}");
        }
    }
}
