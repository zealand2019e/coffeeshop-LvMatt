using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class FlatWhite : Coffee, Milk
    {
        public override string Strength()
        {
            return "weak";
        }
        public override string name()
        {
            return "Flat White";
        }

        public int mlMilk()
        {
            return 50;
        }
        public override string filter()
        {
            return "Akmel";
        }
    }
}
