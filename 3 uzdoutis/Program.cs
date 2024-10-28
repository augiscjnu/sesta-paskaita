using System;

namespace trecia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kiek studentų norite įvesti?");
            int studentuKiekis = int.Parse(Console.ReadLine());

            Studentas[] studentai = new Studentas[studentuKiekis];

            for (int i = 0; i < studentuKiekis; i++)
            {
                studentai[i] = new Studentas();

                Console.WriteLine($"Įveskite {i + 1}-osios studento vardą:");
                studentai[i].Vardas = Console.ReadLine();

                Console.WriteLine($"Kiek pažymių norite įvesti {studentai[i].Vardas}?");
                int pazymiuKiekis = int.Parse(Console.ReadLine());
                studentai[i].Pazymiai = new int[pazymiuKiekis];

                for (int j = 0; j < pazymiuKiekis; j++)
                {
                    Console.WriteLine($"Įveskite {j + 1}-ąjį pažymį:");
                    studentai[i].Pazymiai[j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nIšlaikė studentai:");
            foreach (var studentas in studentai)
            {
                if (studentas.Islaike())
                {
                    Console.WriteLine($"{studentas.Vardas} - Vidurkis: {studentas.Vidurkis():F2}");
                }
            }
        }
    }
}
