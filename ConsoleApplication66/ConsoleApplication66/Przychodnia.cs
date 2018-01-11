using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication66
{
    class Przychodnia:IPrzychodnia
    {
        private Lekarz lekarz;
        private Queue<Pacjent> pacjenci = new Queue<Pacjent>();

        public int CzasOczekiwania()
        {
            return pacjenci.Count/4;
        }

        public void DodajDoKolejki(string imie, string nazwisko, int wiek, string chroba)
        {
            pacjenci.Enqueue(new Pacjent(imie, nazwisko,chroba,wiek));
        }

        public void GenerujRaport()
        {
            string nazwaPliku = "Raport" + DateTime.Now.ToString("HHmmddMMyyyy") + ".txt";
            string tresc = ToString();
            using(StreamWriter sw = new StreamWriter(nazwaPliku))
            {
                sw.Write(tresc);
            }
        }

        public void UstawLekarza(string imie, string nazwisko, string specjalnosc)
        {
            lekarz = new Lekarz(imie, nazwisko,specjalnosc);
        }

        public void WykonajBadanie()
        {
            Console.WriteLine("Wykonano badanie! " + pacjenci.Peek().ToString());
        }

        public void WykonajPorade()
        {
            Console.WriteLine("Wykonano poradę! "+pacjenci.Dequeue().ToString());
        }

        public override string ToString()
        {
            string opis="";
            opis += lekarz.ToString() + Environment.NewLine;
            opis += "Pacjenci w kolejce" + Environment.NewLine;
            foreach(var element in pacjenci)
            {
                opis += element.ToString();
            }
            opis += "CzasOczekiwania: " + CzasOczekiwania();
            return opis;
        }

        public bool CzyLekarz()
        {
            if (lekarz != null) return true;
            return false;
        }
    }
}
