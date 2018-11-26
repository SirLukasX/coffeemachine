using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kaffeeautomat
{
    class DrinkMelange : Drink
    {
        /// <summary>
        /// Amount of coffeePowder in mg
        /// </summary>
        public override int CoffeePowder
        {
            get;
            set;
        }

        /// <summary>
        /// Amount of water in ml
        /// </summary>
        public override int Water
        {
            get;
            set;
        }

        /// <summary>
        /// Amount of milkPowder in mg
        /// </summary>
        public override int MilkPowder
        {
            get;
            set;
        }

        /// <summary>
        /// Amount of sugar in mg
        /// </summary>
        public override int Sugar
        {
            get;
            set;
        }
    }
}
