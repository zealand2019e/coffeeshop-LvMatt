using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {
        public override string Strength()
        {
            return "strong";
        }
        public override int discount()
        {
            return 3;
        }

        public override string name()
        {
            return "Black Coffee";
        }
        public override string filter()
        {
            return "Kieni";
        }
    }
}
