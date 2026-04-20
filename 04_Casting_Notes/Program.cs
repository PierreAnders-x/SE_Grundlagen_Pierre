var auto = new Auto();
var motorrad = new Motorrad();
var Fahrzeugliste = new List<Fahrzeug> { auto, motorrad }; // Eine Liste von Fahrzeugen wird erstellt und mit einem Auto- und einem Motorrad-Objekt gefüllt. Da Auto und Motorrad beide von der Klasse Fahrzeug erben, können sie in einer Liste vom Typ Fahrzeug gespeichert werden.

Fahrzeug fahrzeug1 = Fahrzeugliste[0]; // Das erste Element der Fahrzeugliste (das Auto) wird in der Variable fahrzeug1 vom Typ Fahrzeug gespeichert. Dies ist eine implizite Konvertierung, da Auto ein Untertyp von Fahrzeug ist und keine Daten verloren gehen können.

var motorrad1 = (Motorrad)fahrzeug1;
motorrad1.Beschleunigen(); // Das erste Element der Fahrzeugliste (das Auto) wird explizit in einen Motorrad-Typ umgewandelt und in der Variable motorrad1 gespeichert. Dies ist eine explizite Konvertierung, da Auto und Motorrad unterschiedliche Typen sind und es zu einem InvalidCastException führen kann, wenn das Objekt tatsächlich nicht vom Motorrad-Typ ist. In diesem Fall wird eine InvalidCastException ausgelöst, da das erste Element der Liste ein Auto ist und nicht in ein Motorrad umgewandelt werden kann.


class Fahrzeug
{
    public void Fahren()
    {
        Console.WriteLine("Das Fahrzeug fährt.");
    }
}

class Auto : Fahrzeug
{
    public void Hupen()
    {
        Console.WriteLine("Das Auto hupt.");
    }
}

class Motorrad : Fahrzeug
{
    public void Beschleunigen()
    {
        Console.WriteLine("Das Motorrad beschleunigt.");
    }
}

