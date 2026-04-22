bool istBool;
bool boolWert = false;

bool istInt;
int intWert = 0;

bool istDouble;
double doubleWert = 0;

string eingabe;
int auswahl;

Console.Write("Bitte gib einen Wert ein: ");
eingabe = Console.ReadLine();

istBool = bool.TryParse(eingabe, out boolWert);
istInt = int.TryParse(eingabe, out intWert);
istDouble = double.TryParse(eingabe, out doubleWert);

if (istBool == true && istInt == false && istDouble == false)
{
    Console.WriteLine("Gewählter Typ: bool");
    Console.WriteLine("Wert: " + boolWert);
}
else if (istBool == false && istInt == true && istDouble == false)
{
    Console.WriteLine("Gewählter Typ: int");
    Console.WriteLine("Wert: " + intWert);
}
else if (istBool == false && istInt == false && istDouble == true)
{
    Console.WriteLine("Gewählter Typ: double");
    Console.WriteLine("Wert: " + doubleWert);
}
else if (istBool == false && istInt == false && istDouble == false)
{
    Console.WriteLine("Gewählter Typ: string");
    Console.WriteLine("Wert: " + eingabe);
}
else
{
    Console.WriteLine("Die Eingabe passt zu mehreren Datentypen.");

    if (istInt == true && istDouble == true)
    {
        Console.WriteLine("1 = int");
        Console.WriteLine("2 = double");
        Console.Write("Bitte wählen: ");
        auswahl = Convert.ToInt32(Console.ReadLine());

        if (auswahl == 1)
        {
            Console.WriteLine("Gewählter Typ: int");
            Console.WriteLine("Wert: " + intWert);
        }
        else
        {
            Console.WriteLine("Gewählter Typ: double");
            Console.WriteLine("Wert: " + doubleWert);
        }
    }
}
