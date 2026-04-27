
using System;
class Programm
{
        static void Main()
    {
        Console.Write("Wie viel möchten sie sparen? ");
        
        if (!double.TryParse(Console.ReadLine(),out double monatsbetrag))
        {

            Console.WriteLine("Bitte geben sie eine gültige zahl ein.");
            return;

        }

        double  gesamtsumme = 0;

        for (int monat = 1; monat <= 12; monat++)
        {
            gesamtsumme += monatsbetrag;

            Console.WriteLine ("Monat" + monat + ":" + gesamtsumme +"Euro gespart");
        }
    }


}
