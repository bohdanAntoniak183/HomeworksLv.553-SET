using System;

namespace Coffee_Machine_Program
{
    enum SortsOfCoffee
    {
        Arabica = 1,
        Robusta,
        Liberica
    }

    class CoffeeSort
    {
        public SortsOfCoffee sortName { get; }

        public uint sortPrice { get; }

        public CoffeeSort(SortsOfCoffee sort, uint price)
        {
            sortName = sort;
            sortPrice = price;
        }
    }
}

