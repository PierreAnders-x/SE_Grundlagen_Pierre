//1.Die switch-Anweisung: "Der digitale Kellner"
//Szenario: Ein Gast betritt ein digitales Café und möchte ein Getränk bestellen.
//Programm gibt aus: "Was möchten Sie trinken? (Kaffee, Tee, Schokolade)"
//Mit switch je nach Eingabe passende Antwort ausgeben (z. B. bei Kaffee: "Hier ist Ihr heißer Wachmacher!")
//default - Fall für unbekannte Getränke





class Program
{
    static void Main()
    {
        Console.WriteLine("Was möchten Sie trinken? (Kaffe,Tee,Schokolade)");
        string getränke = Console.ReadLine().ToLower();

            switch (getränke)
        {
           
            
            case "kaffee":
                Console.WriteLine("Hier ist ihr Wachmacher!");
            break;

            case "tee":
                Console.WriteLine("Hier isr ihr Warmmacher!");
            break;

            case "schokolade":
                Console.WriteLine("Vorsicht brennt!");
            break;

            default: Console.WriteLine("Sorry für dich gibts nix");
            break;




        }


    }




}
