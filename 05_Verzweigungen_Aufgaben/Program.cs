
double BierinL; //Bier in Liter
double BierinMl; //Alcohol in Milliliter
double AiG; //Alcohol in Gramm
double GewichtInKg; //Gewicht in Kilogramm
double Promille; //Promille
string Geschlecht; //Geschlecht des Benutzers

Console.WriteLine("Geben Sie Ihr Geschlecht ein (männlich/weiblich):");
Geschlecht = Console.ReadLine() ?? "";

Console.WriteLine("Geben Sie die Menge Bier in Liter ein:");
BierinL = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Geben Sie Ihren Gewicht in Kilogramm ein:");
GewichtInKg = Convert.ToDouble(Console.ReadLine());

BierinMl = BierinL * 1000; //Umrechnung von Liter in Milliliter 
AiG = BierinMl * 0.05 * 0.8; //Berechnung des Alkohols in Gramm (5% Alkoholgehalt)
Promille = AiG / (GewichtInKg * 0.65 * GewichtInKg); //Berechnung der Promille (0.65 ist der Verteilungsfaktor für Männer, für Frauen wäre es 0.55)
