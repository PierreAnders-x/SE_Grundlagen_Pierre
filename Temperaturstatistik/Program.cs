namespace Temperaturstatistik
{
    internal class Temperaturstatistik
    {
        
        private List <double> _messwerte = new List<double>();

        public void NeueMessungErfassen(double wert)
        {
            _messwerte.Add(wert);
        }
           public double Durchschnitt()
        {
            return _messwerte.Average();
        } 
        public double Maximalwert()
        {
            return _messwerte.Max();
        }
        
    }
}
