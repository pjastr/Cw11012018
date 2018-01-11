using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Pokoj:IComparable<Pokoj>
    {
        private int nrPokoju;
        private double cenaZaDzien;

        public Pokoj(int nrPokoju, double cenaZaDzien)
        {
            this.cenaZaDzien = cenaZaDzien;
            this.nrPokoju = nrPokoju;
        }

        public override string ToString()
        {
            return "Pokój: nr:"+nrPokoju+", cena za dzień:"+cenaZaDzien;
        }


        public int PobierzNrPokoju()
        {
            return nrPokoju;
        }

        public double PobierzCene()
        {
            return cenaZaDzien;
        }

        public int CompareTo(Pokoj other)
        {
            return this.nrPokoju.CompareTo(other.nrPokoju);
        }

    }
}
