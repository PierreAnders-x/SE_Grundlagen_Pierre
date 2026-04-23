//Der User soll Ihnen mitteilen, ob das Wetter gerade "sonnig" oder "regnerisch" ist.
//Auch die Temperatur soll der User angeben können.
//Liegt die Temperatur bei oder über 20°C und es ist sonnig, empfehlen sie dem User ein T-Shirt zu tragen.
//Liegt die Temperatur unter 20°C und es ist sonnig, empfehlen Sie eine Jacke anzuziehen.
//Bei regnerischen Wetter müssen ebenfalls die Kleiderempfehlung ausgesprochen werden die sich nach der jeweiligen Temperatur richten.
//Zusätzlich soll der User drauf hingewiesen werden, dass ein Regenschirm mitgenommen werden soll.



using System;

class Program
{
    static void Main()
    {
        Console.Write("Wie ist das Wetter gerade? (sonnig/regnerisch): ");
        string wetter = Console.ReadLine().ToLower();

        Console.Write("Wie hoch ist die Temperatur in °C? ");
        int temperatur = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Kleiderempfehlung ---");

        if (wetter == "sonnig")
        {
            if (temperatur >= 20)
            {
                Console.WriteLine("Es ist sonnig und warm. Trage am besten ein T-Shirt.");
            }
            else
            {
                Console.WriteLine("Es ist sonnig, aber eher kühl. Zieh besser eine Jacke an.");
            }
        }
        else if (wetter == "regnerisch")
        {
            if (temperatur >= 20)
            {
                Console.WriteLine("Es ist regnerisch, aber warm. Ein T-Shirt reicht, aber nimm einen Regenschirm mit.");
            }
            else
            {
                Console.WriteLine("Es ist regnerisch und kühl. Zieh eine Jacke an und nimm einen Regenschirm mit.");
            }
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe beim Wetter. Bitte gib nur 'sonnig' oder 'regnerisch' ein.");
        }
    }
}







