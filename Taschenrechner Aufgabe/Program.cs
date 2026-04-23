//Erstellen Sie einen einfachen Taschenrechner.
//Der User soll nacheinander zwei Zahlen und auch  
//ein Zeichen für die Rechenart eingeben können (+ - * / ) können.
//Anschließend wird die Berechnung durchgeführt und das Ergebnis ausgegeben.
//Nach Ausgabe des Ergebnis fragen Sie den User ob er eine weitere Berechnung durchführen möchte oder ob er das Programm verlassen will. schreiben sie dafür ihre logik in eine while schleife:

//while (true)

//hier könnte Ihr code stehe oder Ihre Werbung





class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Bitte gib die erste Zahl ein: ");
            if (!double.TryParse(Console.ReadLine(), out double zahl1))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.\n");
                continue;
            }

            Console.Write("Bitte gib die zweite Zahl ein: ");
            if (!double.TryParse(Console.ReadLine(), out double zahl2))
            {
                Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.\n");
                continue;
            }

            Console.Write("Bitte gib die Rechenart ein (+, -, *, /): ");
            string rechenzeichen = Console.ReadLine();

            double ergebnis;

            if (rechenzeichen == "+")
            {
                ergebnis = zahl1 + zahl2;
            }
            else if (rechenzeichen == "-")
            {
                ergebnis = zahl1 - zahl2;
            }
            else if (rechenzeichen == "*")
            {
                ergebnis = zahl1 * zahl2;
            }
            else if (rechenzeichen == "/")
            {
                if (zahl2 == 0)
                {
                    Console.WriteLine("Division durch 0 ist nicht erlaubt.\n");
                    continue;
                }

                ergebnis = zahl1 / zahl2;
            }
            else
            {
                Console.WriteLine("Ungültige Rechenart.\n");
                continue;
            }

            Console.WriteLine("Das Ergebnis ist: " + ergebnis);

            Console.Write("Möchtest du eine weitere Berechnung durchführen? (ja/nein): ");
            string antwort = Console.ReadLine().ToLower();

            if (antwort == "nein")
            {
                Console.WriteLine("Programm wird beendet.");
                break;
            }

            Console.WriteLine();
        }
    }
}
