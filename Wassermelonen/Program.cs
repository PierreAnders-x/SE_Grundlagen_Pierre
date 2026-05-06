using System;

class Program
{
    static void Main()
    {
        Console.Write("Preis pro Melone in Euro: ");
        double preisProMelone = double.Parse(Console.ReadLine());

        Console.Write("Bestellmenge: ");
        int anzahl = int.Parse(Console.ReadLine());

        DateTime dt = DateTime.Now;

        double rabatt = 0;

        // Rabatt berechnen
        if (dt.DayOfWeek == DayOfWeek.Thursday)
        {
            if (anzahl >= 10)
            {
                rabatt = 0.12;
            }
            else if (anzahl >= 5)
            {
                rabatt = 0.07;
            }
        }
        else
        {
            if (anzahl >= 10)
            {
                rabatt = 0.10;
            }
            else if (anzahl >= 5)
            {
                rabatt = 0.05;
            }
        }

        double zwischensumme = preisProMelone * anzahl;
        double rabattBetrag = zwischensumme * rabatt;
        double netto = zwischensumme - rabattBetrag;

        double mwstSatz = 0.07;   // Beispielwert 7 %
        double mwstBetrag = netto * mwstSatz;

        double gesamtbetrag = netto + mwstBetrag;

        Console.WriteLine();
        Console.WriteLine("========= QUITTUNG =========");
        Console.WriteLine("Datum: " + dt.ToString("dd.MM.yyyy HH:mm"));
        Console.WriteLine("Tag: " + dt.ToString("dddd"));
        Console.WriteLine("----------------------------");
        Console.WriteLine("Preis pro Melone: " + preisProMelone.ToString("0.00") + " €");
        Console.WriteLine("Bestellmenge:     " + anzahl);
        Console.WriteLine("Zwischensumme:    " + zwischensumme.ToString("0.00") + " €");
        Console.WriteLine("Rabatt:           " + (rabatt * 100) + " %");
        Console.WriteLine("Rabattbetrag:     " + rabattBetrag.ToString("0.00") + " €");
        Console.WriteLine("Netto:            " + netto.ToString("0.00") + " €");
        Console.WriteLine("MwSt. (7%):       " + mwstBetrag.ToString("0.00") + " €");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Zu zahlen:        " + gesamtbetrag.ToString("0.00") + " €");
        Console.WriteLine("============================");
    }
}