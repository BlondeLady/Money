using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1k2c_1._5_1_
{
    class Money
    {
        private int _grivna;
        private int _kopiyka;
        private double _dollarCost;
        public Money(int grivna, int kopiyka, double dollarCost)
        {
            Grivna = grivna;
            Kopiyka = kopiyka;
            DollarCost = dollarCost;
        }
        public int Grivna
        {
            get => _grivna;
            set => _grivna = value != 0 ? value : 0;
        }
        public int Kopiyka
        {
            get => _kopiyka;
            set => _kopiyka = value != 0 ? value : 0;
        }
        public double DollarCost
        {
            get => _dollarCost;
            set => _dollarCost = value != 0 ? value : 0;
        }

        public int this[int index]//indexer
        {
            get { return _grivna[index]; }
            set { _grivna[index] = value; }
        }


        //public override string ToString() => $"{Grivna} {Kopiyka} {DollarCost}";
        //public static double ToDollar()
        //{

        //}
       
    }
}

