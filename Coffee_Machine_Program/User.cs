using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Machine_Program
{
    class User
    {
        public uint UserMoney { get; private set; }

        public User(uint userMoney)
        {
            UserMoney = userMoney;
        }

        public uint SelectSortOfCoffee()
        {
            try
            {
                uint selectNumber = UInt32.Parse(Console.ReadLine());
                return selectNumber;
            }
            catch
            {
                return 0;
            }
        }

        public uint GiveMoney(CoffeeSort sort)
        {
            UserMoney = UserMoney - sort.sortPrice;
            return sort.sortPrice;
        }
    }
}
