int schulnoten;

// User gibt schulnote ein 
Console.WriteLine("Gib eine Note ein");
schulnoten = int.Parse(Console .ReadLine());

// werte die schulnore aus mithilfe der switch-anweisung
switch (schulnoten)
{
    case 1:
        
        Console.WriteLine("Note ist sehr gut");
        break;

        case 2: Console.WriteLine("Note ist gut")
            ; break;

        case 3: Console.WriteLine("Note ist befriedigend")
            ; break;

        case 4: Console.WriteLine("Note ist ausreichend")
            ; break;

        case 5: Console.WriteLine("Note ist ausreichend");
            break;

        case 6: Console.WriteLine("Note ist ungenügend");
            break;

        default: Console.WriteLine("Ungültige Note");
            break;


        //Die Switch-Anweisung ist sinnvol, wenn mehrere fälle und alle Ausdrücke *konstante Werte* sind. Sie ist übersichtlicher als eine lange if-else-if-else kette 





}