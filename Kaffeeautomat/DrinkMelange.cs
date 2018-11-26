﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMaker
{
    class DrinkMelange : Drink
    {
        public DrinkMelange()
        {
            CoffeePowder = 8;
            Water = 100;
            MilkPowder = 5;
            Sugar = 5;
        }
    }
}
