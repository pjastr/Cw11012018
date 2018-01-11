using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Hotel:IHotel, IData
    {
        private SortedDictionary<Pokoj, Gosc> rezerwacje = new SortedDictionary<Pokoj,Gosc>();
        private double zysk;
        private DateTime data;

        public Hotel()
        {
            zysk = -80;
        }

        public void DodajRezerwacje(string imie, string nazwisko, int nrPokoju, double cenaZaDzien)
        {
            rezerwacje.Add(new Pokoj(nrPokoju,cenaZaDzien),new Gosc(imie,nazwisko));
            zysk += cenaZaDzien;
        }

        public void OdwolajRezerwacje()
        {
            rezerwacje.Remove(rezerwacje.Last().Key);
        }



        public void UstawDate(DateTime p1)
        {
            this.data = p1;
        }

        public bool SprawdzDate()
        {
            if (data > DateTime.Now)
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            string opis="";
            opis += "Rezerwacje:" + Environment.NewLine;
            opis += "Data: " + data + Environment.NewLine;
            foreach(var element in rezerwacje)
            {
                opis += element.ToString() + Environment.NewLine;
            }
            opis += "Zysk: " + zysk;
            return opis;
        }

        public int IloscRezerwacji()
        {
            return rezerwacje.Count;
        }
    }
}
