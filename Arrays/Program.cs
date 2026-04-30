using System.Reflection.Metadata.Ecma335;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {



            bool item;
            int[] UserZahlen = new int[6];
            int[] LottoZahlen = new int[6];
            Random rnd = new Random();
            int treffer = 0;

            Console.WriteLine("Hallo User,wilkommen bei Lotto.Bitte gib deine Zahlen von 6-49 ein.Viel Glück.");

            //Zahlen von User mit Schleife
            for (int i = 0; i < 6; i++)

                do
                {
                    item = true; 
                    Console.Write("Zahl" + (i + 1) + ":");

                    if (!int.TryParse(Console.ReadLine(), out UserZahlen[i]))
                    {
                        Console.WriteLine("Bitte gib eine gültige Zahl ein.");
                        item = false;
                    }


                    if (UserZahlen[i] < 1 || UserZahlen[i] > 50)
                    {
                        Console.WriteLine("Bitte nur gültige zahlen eingeben.");
                        item = false;
                    }
                    

                    for (int j = 0; j < i; j++)
                    {
                        if (UserZahlen[j] == UserZahlen[i])
                        {
                            item = false;
                            Console.WriteLine("Diese Zahl wurde bereits verwendet.");

                        }

                        
                        

                       



                    }


                } while (!item);
        }
    }
}


