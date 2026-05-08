using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturstatistik_2
{
    internal class Temp
    {
        private List<double> _messwerte = new List<double>();




        public void NeueMessung(double wert)
        {
            _messwerte.Add(wert);
        }
        public double Durchschnitt()
        { return _messwerte.Average(); }

        public double Maximalwert()
        { return _messwerte.Max(); }



    }
}
