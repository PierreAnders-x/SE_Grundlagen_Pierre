double bierInLitern;
double bierInMillilitern;
double alkoholInGramm;
double gewichtInKg;
double promille;

Console.Write("Wie viel Bier wurde in Litern getrunken? ");
bierInLitern = Convert.ToDouble(Console.ReadLine());

Console.Write("Wie viel wiegst du in Kilogramm? ");
gewichtInKg = Convert.ToDouble(Console.ReadLine());

bierInMillilitern = bierInLitern * 1000;
alkoholInGramm = bierInMillilitern * 0.05 * 0.8;
promille = alkoholInGramm / (0.65 * gewichtInKg);

Console.WriteLine("Reinalkohol in Gramm: " + alkoholInGramm);
Console.WriteLine("Blutalkoholgehalt in Promille: " + promille);

if (promille <= 0.3)
{
    Console.WriteLine("Noch akzeptabel. Dennoch vorsichtig sein!");
}
else if (promille <= 0.5)
{
    Console.WriteLine("Achtung! Hände weg vom Steuer!");
}
else if (promille < 0.8)
{
    Console.WriteLine("Das ist jetzt schon ganz schön ordentlich.");
}
else
{
    Console.WriteLine("Kein Kommentar...");
}
