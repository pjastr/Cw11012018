using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Program
    {
        private static Hotel hotelik = new Hotel();
        private static char klawisz;
        
        public static void Legenda()
        {
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("A - ustaw date");
            Console.WriteLine("B - dodaj rezerwacje");
            Console.WriteLine("C - usuń rezerwacje");
            Console.WriteLine("D - wypisz rezerwacje");
            Console.WriteLine("X - wyjście z aplikacji");
        }

        public static void WczytajKlawisz()
        {
            klawisz = Convert.ToChar(Console.ReadLine());
        }

        public static void Dzialanie()
        {
            if (klawisz == 'A' || klawisz == 'a')
            {
                Console.WriteLine("Podaj date rezerwacji w formacie yyyy-MM-dd");
                string wejscie = null;
                DateTime data;
                bool okData = false;
                while (!okData)
                {
                    wejscie = Console.ReadLine();
                    while (!DateTime.TryParse(wejscie, out data))
                    {
                        Console.WriteLine("błędna data, podaj datę w formacie yyyy-MM-dd i większą od daty dzisiejszej");
                        wejscie = Console.ReadLine();
                    }
                    hotelik.UstawDate(data);
                    if (hotelik.SprawdzDate()) break;
                    else
                    {
                        Console.WriteLine("błędna data, podaj datę w formacie yyyy-MM-dd i większą od daty dzisiejszej");
                    }
                        
                }
                 

                
            }
            else if (klawisz == 'B' || klawisz == 'b')
            {
                if (hotelik.SprawdzDate() == true)
                {
                    int numer = 0;
                    string wej2 = "";
                    while (numer <= 0)
                    {
                        Console.WriteLine("Podaj numer pokoju");
                        wej2 = Console.ReadLine();
                        Int32.TryParse(wej2, out numer);
                    }
                    double cena = 0;
                    while (cena <= 0)
                    {
                        Console.WriteLine("Podaj cenę za dzień");
                        wej2 = Console.ReadLine();
                        Double.TryParse(wej2, out cena);
                    }
                    string imie = "";
                    while (String.IsNullOrEmpty(imie))
                    {
                        Console.WriteLine("Podaj imie");
                        imie = Console.ReadLine();
                    }
                    string nazwisko = "";
                    while (String.IsNullOrEmpty(nazwisko))
                    {
                        Console.WriteLine("Podaj nazwisko");
                        nazwisko = Console.ReadLine();
                    }
                    hotelik.DodajRezerwacje(imie, nazwisko, numer, cena);
                }
                else
                {
                    Console.WriteLine("ustaw poprawną date rezerwacji");
                }
            }
            else if (klawisz =='C' || klawisz=='c')
            {
                if (hotelik.SprawdzDate() == true)
                {
                    if (hotelik.IloscRezerwacji() > 0)
                    {
                        hotelik.OdwolajRezerwacje();
                        Console.WriteLine("Odwołano rezerwacje");
                    }
                    else
                    {
                        Console.WriteLine("brak rezerwacji, nic nie usunieto");
                    }
                }
                else
                {
                    Console.WriteLine("ustaw poprawną date rezerwacji");
                }
            }
            else if (klawisz =='D' || klawisz=='d')
            {
                if (hotelik.SprawdzDate() == true)
                {
                    Console.WriteLine(hotelik.ToString());
                }
                else
                {
                    Console.WriteLine("ustaw poprawną date rezerwacji");
                }
            }
            else if (klawisz == 'X' || klawisz == 'X')
            {
                Environment.Exit(0);
            }
        }
        
        static void Main(string[] args)
        {
            while(true)
            {
                Legenda();
                WczytajKlawisz();
                Dzialanie();

            }
            
        }
    }
}
