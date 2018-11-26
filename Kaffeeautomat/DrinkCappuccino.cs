using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMaker
{
    class DrinkCappuccino : Drink
    {
        public DrinkCappuccino()
        {
            CoffeePowder = 8;
            Water = 100;
            MilkPowder = 10;
            Sugar = 5;
        }
    }
}
