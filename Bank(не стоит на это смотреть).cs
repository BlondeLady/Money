using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1k2c_1._5_1_
{
    class Bank
    {
        Money[] indexer;
        public Bank(Money[] cash) => indexer = cash;
        public Money this[int index]
        {
            get => indexer[index];
            set => indexer[index] = value;
        }
    }
}
