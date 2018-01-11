using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Lekarz:Osoba
    {
        private string specjalnosc;


        public Lekarz(string imie, string nazwisko, string specjalnosc)
            :base(imie, nazwisko)
        {
            this.specjalnosc = specjalnosc;
        }

        public override string ToString()
        {
            return String.Format("Lekarz. imię i nazwisko: {0} {1}, specjalnosc: {2}", imie, nazwisko,specjalnosc);
        }
    }
}
