using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, Milk
    {
        public override int price()
        {
            // Inherit new price
            return 40;
        }
        public override string Strength()
        {
            return "weak";
        }

        public int mlMilk()
        {
            return 200;
        }
        public override string name()
        {
            return "Latte";
        }
        public override int discount()
        {
            return -5;
        }
        public override string filter()
        {
            return "Kieni";
        }
    }
}
