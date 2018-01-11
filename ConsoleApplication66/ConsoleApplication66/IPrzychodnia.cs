using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    interface IPrzychodnia
    {
        int CzasOczekiwania();
        void DodajDoKolejki(string imie, string nazwisko, int wiek, string chroba);

        void GenerujRaport();

        void UstawLekarza(string imie, string nazwisko, string specjalnosc);

        void WykonajBadanie();

        void WykonajPorade();
    }
}
