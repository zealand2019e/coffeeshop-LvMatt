using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, Milk
    {
        public int mlMilk()
        {
            return 40;
        }

        public override int discount()
        {
            return -5;
        }
        public override string name()
        {
            return "Cortado";
        }

        public override int price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "medium";
        }
        public override string filter()
        {
            return "Akmel";
        }

    }
}
