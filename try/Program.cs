

using System.Data;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hallo User, bitte wähle ein getränk (kaffee,tee,cola)");
        string drinks = Console.ReadLine().ToLower();
        Console.Clear();
        


        switch (drinks)
        {
            case "kaffee":

                Console.WriteLine("Hier ist ihr Wachmacher!");

                break;

            case "tee":
                Console.WriteLine("Hier ist ihr Warmamacher!");
                break;


            case "cola":
                Console.WriteLine("Hier ist ihre cola!");
                break;

            default: Console.WriteLine("ungültige eingabe");
                break;

        }
    }
}



    


        


   










     