using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Pacjent:Osoba
    {
        private string choroba;
        private int wiek;

        public Pacjent(string imie, string nazwisko, string chroba, int wiek)
            :base(imie, nazwisko)
        {
            this.choroba = chroba;
            this.wiek = wiek;
        }

        public override string ToString()
        {
            return String.Format("Pacjent. imię i nazwisko: {0} {1}, wiek: {2}, choroba: {3}.", imie, nazwisko,wiek,choroba);
        }


    }
}
