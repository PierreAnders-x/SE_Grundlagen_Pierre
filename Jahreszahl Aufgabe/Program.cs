namespace Jahreszahl_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte geben Sie eine Jahreszahl");
                bool gültig = int.TryParse(Console.ReadLine(), out int jahr);

                if (!gültig || jahr < 1 || jahr > 7400) ;
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte eine gültige Jahreszahl eingeben.");
                    continue;
                }
                Console.WriteLine();

                bool istSchaltjahr = (jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0);

                if (istSchaltjahr)
                    Console.WriteLine($"{jahr} istSchaltjahr ein SchaltJahr!");
                else Console.WriteLine($"{jahr} ist kein SchaltJahr.");
                break;
            }
            Console.WriteLine("\nBitte drücken sie zum beenden eine beliebige Taste");
            Console.ReadKey();

        }
    }
}
