using System;

class Konto
{
    // private Felder
    private string kontonummer;
    private double saldo;

    // Konstruktor, damit das Konto direkt eine Nummer und einen Startsaldo bekommt
    public Konto(string kontonummer, double saldo)
    {
        this.kontonummer = kontonummer;
        this.saldo = saldo;
    }

    // Geld einzahlen
    public void Einzahlen(double betrag)
    {
        if (betrag > 0)
        {
            saldo += betrag;
            Console.WriteLine(betrag + " Euro wurden eingezahlt.");
        }
        else
        {
            Console.WriteLine("Bitte einen gültigen Betrag eingeben.");
        }
    }

    // Geld abheben
    public void Abheben(double betrag)
    {
        if (betrag <= 0)
        {
            Console.WriteLine("Bitte einen gültigen Betrag eingeben.");
        }
        else if (betrag > saldo)
        {
            Console.WriteLine("Abheben nicht möglich. Nicht genug Guthaben.");
        }
        else
        {
            saldo -= betrag;
            Console.WriteLine(betrag + " Euro wurden abgehoben.");
        }
    }

    // Saldo anzeigen
    public void SaldoAnzeigen()
    {
        Console.WriteLine("Kontonummer: " + kontonummer);
        Console.WriteLine("Aktueller Saldo: " + saldo + " Euro");
    }
}

class Program
{
    static void Main()
    {
        Konto meinKonto = new Konto("DE123456789", 500);

        meinKonto.SaldoAnzeigen();
        Console.WriteLine();

        meinKonto.Einzahlen(200);
        meinKonto.SaldoAnzeigen();
        Console.WriteLine();

        meinKonto.Abheben(100);
        meinKonto.SaldoAnzeigen();
        Console.WriteLine();

        meinKonto.Abheben(700);
        meinKonto.SaldoAnzeigen();
    }
}