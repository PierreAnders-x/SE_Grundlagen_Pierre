//Eine Variable speichert einen Wert im Arbeitsspecher und macht diesen Wert zugänglich mit einem Bezeichner.
//<Datentyp> <Bezeichner> = <Wert>;

using System.Runtime.InteropServices;

int alter; //Initialisierung einer Variable vom Typ int (Ganzzahl) mit dem Namen "alter". Der Wert der Variable ist zu diesem Zeitpunkt noch nicht festgelegt und wird als Standardwert 0 angenommen.

alter = 30; // Wert der Variable "alter" wird auf 30 gesetzt. Jetzt enthält die Variable den Wert 30, der als Ganzzahl interpretiert wird.

// Integer ist der Datentyp für Ganzzahlen
int eineZahl; 
System.Int32 eineWeitereZahl = 2147483647; // Integer hat einen Wertebereich von -2.147.483.648 bis 2.147.483.647, da er 32 Bit (4 Byte) Speicherplatz verwendet. Das bedeutet, dass die Variable "eineZahl" einen Wert innerhalb dieses Bereichs speichern kann. In diesem Fall wird der Wert 2.147.483.647 zugewiesen, was der maximale positive Wert für einen Integer ist.

uint einePositiveZahl = 4294967295; // Der Datentyp "uint" steht für "unsigned integer" und speichert nur positive Ganzzahlen. Er verwendet ebenfalls 32 Bit (4 Byte) Speicherplatz, hat jedoch einen Wertebereich von 0 bis 4.294.967.295, da er keine negativen Werte speichern kann. In diesem Fall wird der Wert 4.294.967.295 zugewiesen, was der maximale positive Wert für einen unsigned integer ist.

Int128 eineSehrGroßeZahl = 2147483647000000000;

// BOOLEANS ist ein Datentyp der nur die Werte "true" (wahr) oder "false" (falsch) annehmen kann. Er wird verwendet, um logische Aussagen zu repräsentieren und Entscheidungen im Code zu treffen. In diesem Fall könnte eine Variable vom Typ Boolean beispielsweise den Namen "istSonnig" haben und den Wert "true" annehmen, wenn es sonnig ist, oder "false", wenn es nicht sonnig ist.

bool wahrOderFalsch =  false;



//Der Char ist ein Datentyp für einzelne Zeichen. Er speichert ein einzelnes Unicode-Zeichen und wird in C# mit einfachen Anführungszeichen ('') dargestellt. In diesem Fall könnte eine Variable vom Typ char beispielsweise den Namen "buchstabe" haben und den Wert 'A' annehmen, um den Buchstaben A zu speichern.

char einZeichen = 'E'; // Der Wert 'A' wird der Variablen "einZeichen" zugewiesen. Jetzt enthält die Variable das einzelne Zeichen 'A', das als char interpretiert wird. In C# werden char-Werte in einfachen Anführungszeichen ('') eingeschlossen, um sie als einzelne Zeichen zu kennzeichnen.

// Der Datentyp "string" wird verwendet, um Textinformationen zu speichern. Er kann eine beliebige Anzahl von Zeichen enthalten, einschließlich Buchstaben, Zahlen und Sonderzeichen. In diesem Fall könnte eine Variable vom Typ string beispielsweise den Namen "name" haben und den Wert "Max Mustermann" annehmen, um den Namen einer Person zu speichern.

string meinText = "Hallo, ich bin ein String!"; // Der Wert "Hallo, ich bin ein String!" wird der Variablen "meinText" zugewiesen. Jetzt enthält die Variable den Text, der als String interpretiert wird. Strings werden in C# in Anführungszeichen ("") eingeschlossen, um sie als Text zu kennzeichnen.
meinText = "Ein Super langer extrem langer Text der unendlich lang ist usw daher habe ich keine Ahhnung wie viel Speicher ich reservieren muss. Meine Länge kann größer als ein komplettes Buch"; // Der Wert der Variablen "meinText" wird auf einen neuen Text geändert. Jetzt enthält die Variable den neuen Text, der ebenfalls als String interpretiert wird. In C# können Strings beliebig lang sein, solange genügend Speicherplatz zur Verfügung steht. Daher ist es möglich, einen sehr langen Text zu speichern, ohne sich Gedanken über die genaue Länge machen zu müssen.

//Ein String ist also genaugenommen nur eine Indexierung von Zeichen (Chars) im Arbeitsspeicher. Jeder Buchstabe, jedes Leerzeichen und jedes Sonderzeichen in einem String wird als einzelnes Zeichen (char) gespeichert, und der String selbst ist eine Sammlung dieser Zeichen. Der Zugriff auf einzelne Zeichen in einem String erfolgt über ihren Index, wobei der erste Buchstabe den Index 0 hat, der zweite den Index 1 usw. Dadurch können wir auf bestimmte Teile des Strings zugreifen oder ihn manipulieren, indem wir die entsprechenden Indizes verwenden.

// Der FLOAT Datentyp wird verwendet, um Gleitkommazahlen mit einfacher Genauigkeit zu speichern. Er verwendet 32 Bit (4 Byte) Speicherplatz und hat einen Wertebereich von ungefähr ±1,5 x 10^−45 bis ±3,4 x 10^38. In diesem Fall könnte eine Variable vom Typ float beispielsweise den Namen "pi" haben und den Wert 3.14 annehmen, um die mathematische Konstante Pi zu speichern.

float meineGleitKommazahl = 0.5f; // Der Wert 0.5 wird der Variablen "meineGleitKommazahl" zugewiesen. Jetzt enthält die Variable die Gleitkommazahl 0.5, die als float interpretiert wird. In C# müssen Gleitkommazahlen vom Typ float mit einem "f" oder "F" am Ende gekennzeichnet werden, um sie als float zu kennzeichnen und nicht als double (Standard-Gleitkommazahl) zu interpretieren.

//Der DOUBLE Datentyp wird verwendet, um Gleitkommazahlen mit doppelter Genauigkeit zu speichern. Er verwendet 64 Bit (8 Byte) Speicherplatz und hat einen Wertebereich von ungefähr ±5,0 x 10^−324 bis ±1,7 x 10^308. In diesem Fall könnte eine Variable vom Typ double beispielsweise den Namen "e" haben und den Wert 2.71828 annehmen, um die mathematische Konstante e zu speichern.

double meineDoppelGleitKommazahl = 0.5; // Der Wert 0.5 wird der Variablen "meineDoppelGleitKommazahl" zugewiesen. Jetzt enthält die Variable die Gleitkommazahl 0.5, die als double interpretiert wird. In C# werden Gleitkommazahlen vom Typ double standardmäßig ohne ein spezielles Suffix gekennzeichnet, da double der Standard-Gleitkommatyp ist. Daher kann die Zahl einfach als 0.5 geschrieben werden, um sie als double zu kennzeichnen.

// Der DECIMAL Datentyp wird verwendet, um Dezimalzahlen mit hoher Genauigkeit zu speichern. Er verwendet 128 Bit (16 Byte) Speicherplatz und hat einen Wertebereich von ungefähr ±1,0 x 10^−28 bis ±7,9 x 10^28. In diesem Fall könnte eine Variable vom Typ decimal beispielsweise den Namen "preis" haben und den Wert 19.99 annehmen, um den Preis eines Produkts zu speichern.
//Der Decimal Datentyp ist besonders nützlich für finanzielle Berechnungen, da er eine höhere Genauigkeit bietet als float oder double und somit Rundungsfehler minimiert. In C# müssen Dezimalzahlen vom Typ decimal mit einem "m" oder "M" am Ende gekennzeichnet werden, um sie als decimal zu kennzeichnen und nicht als double zu interpretieren.
decimal preis = 19.99m; // Der Wert 19.99 wird der Variablen "preis" zugewiesen. Jetzt enthält die Variable den Dezimalwert 19.99, der als decimal interpretiert wird. In C# müssen Dezimalzahlen vom Typ decimal mit einem "m" oder "M" am Ende gekennzeichnet werden, um sie als decimal zu kennzeichnen und nicht als double (Standard-Gleitkommazahl) zu interpretieren. Daher wird die Zahl als 19.99m geschrieben, um sie als decimal zu kennzeichnen.

//VARIABLEN


string einGanzBesondererText = "Mein Cooler Text";

Console.WriteLine(einGanzBesondererText);

einGanzBesondererText = "Mein Noch Coolerer Text";

Console.WriteLine(einGanzBesondererText);
//Unser Programmfluss läuft von oben nach unten. Das bedeutet, dass die Anweisungen in der Reihenfolge ausgeführt werden, in der sie im Code erscheinen. In diesem Fall wird zuerst der Text "Mein Cooler Text" auf der Konsole ausgegeben, da dies der Wert ist, der der Variablen "einGanzBesondererText" zugewiesen wurde. Danach wird der Wert der Variablen geändert und auf "Mein Noch Coolerer Text" gesetzt, was dazu führt wenn wir die Funktion "WriteLine()" erneut mit dieser Variable aufrufen dieser den neuen Text in der Shell ausgibt.

decimal preis2 = 10.50m;
string text = "Was ist der letzte Preis? ";
Console.WriteLine(text + preis2);

int zahl1 = 5;
int zahl2 = 10;

int zahl3 = zahl1 + zahl2; // In diesem Fall wird die Variable "zahl3" den Wert 15 annehmen, da sie die Summe von "zahl1" (5) und "zahl2" (10) ist. Die Addition von zwei Ganzzahlen ergibt eine neue Ganzzahl, die in diesem Fall 15 ist.

Console.WriteLine(zahl3);

//Operator sind schlüsselwörter/Zeichen die bestimmte Operationen auf Variablen oder Werten ausführen. 

//+-*/% sind die arithmetischen Operatoren für Addition, Subtraktion, Multiplikation, Division und Modulo (Restwert einer Division). In diesem Fall könnte eine Variable "ergebnis" beispielsweise den Wert 15 annehmen, wenn sie die Summe von 5 und 10 berechnet, oder den Wert 50, wenn sie das Produkt von 5 und 10 berechnet. Diese Operatoren ermöglichen es uns, mathematische Berechnungen durchzuführen und Werte zu manipulieren.

var zahl4 = 53;
var zahl5 = 8;

Console.WriteLine(zahl4 + zahl5);// Ausgabe: 61 (Addition von 53 und 8)
Console.WriteLine(zahl4 * zahl5); //Ausgabe: 424 (Multiplikation von 53 und 8)
Console.WriteLine(zahl4 / zahl5); // Ausgabe: 6 (Ganzzahlige Division von 53 durch 8, da beide Operanden vom Typ int sind)
Console.WriteLine(53 % 8);// Ausgabe: 5 (Der Modulo-Operator gibt den Rest der Division von 53 durch 8 zurück, da 53 durch 8 genau 6 Mal passt und einen Rest von 5 hat)

// && -> und Operator 
var antwort = true && false; // Ausgabe: false (Der Ausdruck "true && false" ergibt false, da beide Operanden wahr sein müssen, damit das Ergebnis wahr ist. In diesem Fall ist einer der Operanden falsch, daher ist das Ergebnis false.)
Console.WriteLine(antwort);

// || -> oder Operator
antwort = true || false; // Ausgabe: true (Der Ausdruck "true || false" ergibt true, da mindestens einer der Operanden wahr sein muss, damit das Ergebnis wahr ist. In diesem Fall ist einer der Operanden wahr, daher ist das Ergebnis true.)
Console.WriteLine(antwort);

// ! -> nicht Operator
antwort = !true; // Ausgabe: false (Der Ausdruck "!true" ergibt false, da der "!"-Operator den Wahrheitswert von true negiert. In diesem Fall wird true zu false, daher ist das Ergebnis false.)
Console.WriteLine(antwort);

// = -> Zuweisungsoperator
antwort = true; // In diesem Fall wird der Wert true der Variablen "antwort" zugewiesen. Jetzt enthält die Variable den Wert true, der als boolescher Wert interpretiert wird. Der Zuweisungsoperator "=" wird verwendet, um einen Wert einer Variablen zuzuweisen, und in diesem Fall wird die Variable "antwort" auf true gesetzt.

// == -> Vergleichsoperator für Gleichheit
antwort = 5 == 5; // Ausgabe: true (Der Ausdruck "5 == 5" ergibt true, da beide Operanden gleich sind. Der Vergleichsoperator "==" überprüft, ob die Werte auf beiden Seiten des Operators gleich sind, und in diesem Fall sind sie es, daher ist das Ergebnis true.)  
Console.WriteLine(antwort);

//var auto1 = new Auto("vw");
//var auto2 = new Auto("vw");
//antwort = auto1 == auto2;
//Console.WriteLine(antwort);// Hier falsch weil wir 2 unterschiedliche Objekte vergleichen. Es wird also false ausgegeben, da auto1 und auto2 unterschiedliche Instanzen der Klasse Auto sind, auch wenn sie den gleichen Namen "vw" haben. In C# vergleicht der "=="-Operator bei Referenztypen standardmäßig die Referenzen (Adressen im Speicher) der Objekte, nicht deren Inhalt. Da auto1 und auto2 unterschiedliche Objekte sind, haben sie unterschiedliche Referenzen, was zu einem Ergebnis von false führt.

//public class Auto
//{
//    private string _name;
//    public Auto(string name)
//    {
//        _name = name;
//    }

//}

// != -> Vergleichsoperator für Ungleichheit
Console.WriteLine(5 != 2);// Ausgabe: true (Der Ausdruck "5 != 2" ergibt true, da die Werte auf beiden Seiten des Operators ungleich sind. Der Vergleichsoperator "!=" überprüft, ob die Werte auf beiden Seiten des Operators ungleich sind, und in diesem Fall sind sie es, daher ist das Ergebnis true.)

// > < >= <= -> Vergleichsoperatoren für Größer, Kleiner, Größer oder Gleich, Kleiner oder Gleich
Console.WriteLine(5 > 5); // Ausgabe: false (Der Ausdruck "5 > 5" ergibt false, da 5 nicht größer als 5 ist. Der Vergleichsoperator ">" überprüft, ob der Wert auf der linken Seite größer als der Wert auf der rechten Seite ist, und in diesem Fall ist das nicht der Fall, daher ist das Ergebnis false.)

Console.WriteLine(5 >= 5); //Ausgabe True weil der Wert auf der Linken Seite größer oder gleich dem Wert auf der Rechten Seite ist. Der Vergleichsoperator ">=" überprüft, ob der Wert auf der linken Seite größer als oder gleich dem Wert auf der rechten Seite ist, und in diesem Fall ist das wahr, da 5 gleich 5 ist, daher ist das Ergebnis true.)


