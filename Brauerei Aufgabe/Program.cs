using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Brauerei_Aufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello User, was wollen sie für einen Kasten zahlen?");
            double preisProKasten = double.Parse(Console.ReadLine());

            Console.Write("Bestelmenge: ");
            int anzahl = int.Parse(Console.ReadLine());

            Console.Write("Bitte geben sie das Datum an: ");

            string datumEingabe = Console.ReadLine();
            
            DatumPrüfen(datumEingabe);
        }
        
        static void DatumPrüfen(string datumText)

        {
            if (DateTime.TryParse(datumText, out DateTime dt ))
            { Console.WriteLine ()}
        }
        

       
        

        

        
        

       
      
            






        
    }
}
