using Microsoft.VisualBasic;

namespace Aufgabe_Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variablen
            Random rnd = new Random();
            int[] gewinn = new int[6];
            int[] tipps = new int[6];
            int richtige = 0;
            bool check;

            // Zufallszahlen generieren
            for (int i = 0; i < gewinn.Length; i++)
            {
                gewinn[i] = rnd.Next(1, 50);
            }

            // Anwender muss seine Tipps eingeben
            for (int i = 0; i < tipps.Length; i++)
            {
                do
                {
                    Console.Write($"Bitte geben Sie Ihre {i + 1}. Zahl ein: ");
                    check = int.TryParse(Console.ReadLine(), out tipps[i]);

                    if (!check || tipps[i] < 1 || tipps[i] > 49)
                    {
                        Console.WriteLine("Bitte nur Ziffern zwischen 1 und 49!");
                        check = false;
                    }
                }
                while (!check);     // Kurzschreibweise von check == false
            }

            // Zahlen vergleichen
            for (int j = 0; j < tipps.Length; j++)
            {
                for (int i = 0; i < gewinn.Length; i++)
                {
                    if (tipps[j] == gewinn[i])
                        richtige++;
                }
            }

            // Alternativ:
            //for (int i = 0; i < tipps.Length; i++)
            //{
            //    if (gewinn.Contains(tipps[i]))
            //        richtige++;
            //}

            // Ausgabe
            Console.Clear();

            Array.Sort(tipps);      // Array automatisch sortieren
            Array.Sort(gewinn);

            Console.Write("Gewinnzahlen:\t");
            foreach (var item in gewinn)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Ihre Tipps:\t");
            foreach (var item in tipps)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"Sie hatten {richtige} Richtige!");
        }
    }
}
