using System;   // Macht Standardbefehle wie Console und Random nutzbar

class Program   // Die Hülle des Programms
{
    static void Main()   // Hier startet das Programm
    {
        int[] userZahlen = new int[6];      // Array für die 6 Zahlen vom User
        int[] lottoZahlen = new int[6];     // Array für die 6 Zufallszahlen
        Random rnd = new Random();          // Zufallszahlengenerator
        int treffer = 0;                    // Zählt später die Treffer

        Console.WriteLine("Hallo User, willkommen bei Lotto");
        Console.WriteLine("Bitte gib 6 verschiedene Zahlen von 1 bis 49 ein.");

        // Diese Schleife läuft 6-mal
        // Ziel: Der User soll genau 6 Zahlen eingeben
        for (int i = 0; i < 6; i++)
        {
            // Diese Schleife wiederholt die Eingabe so lange,
            // bis eine gültige Zahl eingegeben wurde
            while (true)
            {
                // i startet bei 0, deshalb schreiben wir i + 1
                // damit der User Zahl 1, Zahl 2 usw. sieht
                Console.Write("Zahl " + (i + 1) + ": ");

                // Eingabe lesen und prüfen, ob es eine ganze Zahl ist
                if (!int.TryParse(Console.ReadLine(), out int eingabe))
                {
                    Console.WriteLine("Bitte gib eine gültige ganze Zahl ein.");
                    continue;   // Springt zurück zum Anfang der while-Schleife
                }

                // Prüfen, ob die Zahl im erlaubten Bereich liegt
                if (eingabe < 1 || eingabe > 49)
                {
                    Console.WriteLine("Bitte nur Zahlen von 1 bis 49 eingeben.");
                    continue;   // Wieder neue Eingabe verlangen
                }

                // Merker: Wir gehen zuerst davon aus,
                // dass die Zahl noch nicht vorhanden ist
                bool schonVorhanden = false;

                // Prüfen, ob der User diese Zahl schon vorher eingegeben hat
                // Es werden nur die Plätze geprüft, die schon gefüllt sind
                for (int j = 0; j < i; j++)
                {
                    // Wenn eine alte Zahl gleich der neuen Eingabe ist
                    if (userZahlen[j] == eingabe)
                    {
                        schonVorhanden = true;   // Dann merken wir uns: Zahl gibt es schon
                        break;                   // Schleife sofort beenden
                    }
                }

                // Falls die Zahl schon einmal eingegeben wurde
                if (schonVorhanden)
                {
                    Console.WriteLine("Diese Zahl hast du schon eingegeben.");
                    continue;   // Neue Eingabe verlangen
                }

                // Wenn alle Prüfungen bestanden sind:
                // Zahl im Array speichern
                userZahlen[i] = eingabe;

                // while-Schleife verlassen,
                // weil diese Eingabe jetzt erfolgreich war
                break;
            }
        }

        // Zeigt auf den nächsten freien Platz im Lotto-Array
        int index = 0;

        // So lange Zufallszahlen ziehen, bis 6 Stück gespeichert wurden
        while (index < 6)
        {
            // Zufallszahl von 1 bis 49 erzeugen
            int zufallszahl = rnd.Next(1, 50);

            // Wieder ein Merker für doppelte Zahlen
            bool schonVorhanden = false;

            // Prüfen, ob die Zufallszahl schon im Lotto-Array vorkommt
            for (int i = 0; i < index; i++)
            {
                if (lottoZahlen[i] == zufallszahl)
                {
                    schonVorhanden = true;   // Zahl ist schon da
                    break;                   // Suche abbrechen
                }
            }

            // Nur wenn die Zahl noch nicht vorhanden ist, wird sie gespeichert
            if (!schonVorhanden)
            {
                lottoZahlen[index] = zufallszahl;   // Zahl speichern
                index++;                            // Nächsten freien Platz nehmen
            }
        }

        // Jetzt vergleichen wir jede User-Zahl mit jeder Lottozahl
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                // Wenn eine Zahl gleich ist, gibt es einen Treffer
                if (userZahlen[i] == lottoZahlen[j])
                {
                    treffer++;   // Trefferzähler erhöhen
                }
            }
        }

        // Überschrift für die Zahlen vom User
        Console.WriteLine("\nDeine Zahlen:");

        // Alle User-Zahlen ausgeben
        for (int i = 0; i < 6; i++)
        {
            Console.Write(userZahlen[i] + " ");
        }

        // Überschrift für die gezogenen Lottozahlen
        Console.WriteLine("\n\nLottozahlen:");

        // Alle Lottozahlen ausgeben
        for (int i = 0; i < 6; i++)
        {
            Console.Write(lottoZahlen[i] + " ");
        }

        // Treffer ausgeben
        Console.WriteLine("\n\nDu hast " + treffer + " Treffer.");
    }
}