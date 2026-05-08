namespace Temperaturstatistik_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Temp temperaturstatistik = new Temp();

            for (int i = 0; i < 100; i++)
            {
                temperaturstatistik.NeueMessung(rnd.NextDouble() * 50.0);
            }

            Console.WriteLine($"Durchschnitt = {temperaturstatistik.Durchschnitt():f2} °C");
            Console.WriteLine($"Maximalwert = {temperaturstatistik.Maximalwert():f2} °C");

        }
    }
}
