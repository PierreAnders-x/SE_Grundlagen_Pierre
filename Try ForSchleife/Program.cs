using System.ComponentModel.Design;

namespace Try_ForSchleife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo User, wie viel möchten sie sparen?? Geben sie einen Betrag ein");

            if (!double.TryParse(Console.ReadLine(),out double monatsbetrag))
            {
                Console.WriteLine("Eingabe ungültig"); 
                return;
            }

            double gesamtsumme = 0;

            for (int monat = 1; monat <= 12 ; monat++) 
               
            {
                gesamtsumme += monatsbetrag;

                Console.WriteLine("Monat" + monat + ":" + gesamtsumme + "Euro gespart");

            }

            
                
            

            















        }

    }
}

