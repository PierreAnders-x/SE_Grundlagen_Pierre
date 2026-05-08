using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Aufgabe
{
    internal class Person
    {
        private string vorname;
        private string nachname;

        public void SetzeVorname(string vorname)
        {
            this.vorname = vorname;

        }
        public void SetzeNachname(string nachname)
        {
            this.nachname = nachname;
        }
        public void SagHallo()
        {
            Console.WriteLine($"Hallo ich heiße {vorname} {nachname}.");
        }
    }


    




}

