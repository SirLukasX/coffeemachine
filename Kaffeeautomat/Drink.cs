using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMaker
{
    public class Drink
    {

        /// <summary>
        /// Amount of coffeePowder in mg
        /// </summary>
        public virtual int CoffeePowder
        {
            get;
            set;
        }

        /// <summary>
        /// Amount of water in ml
        /// </summary>
        public virtual int Water
        {
            get;
            set;
        }

        /// <summary>
        /// Amount of milkPowder in mg
        /// </summary>
        public virtual int MilkPowder
        {
            get;
            set;
        }

        /// <summary>
        /// Amount of sugar in mg
        /// </summary>
        public virtual int Sugar
        {
            get;
            set;
        }

        /// <summary>
        /// Amount of choco in mg
        /// </summary>
        public virtual int Choco
        {
            get;
            set;
        }
    }    
}