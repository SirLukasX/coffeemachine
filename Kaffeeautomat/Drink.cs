using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kaffeeautomat
{
    public class Drink
    {
        public virtual int Coffee
        {
            get;
            set;
        }

        public virtual int Water
        {
            get;
            set;
        }

        public virtual int MilkPowder
        {
            get;
            set;
        }

        public virtual int Sugar
        {
            get;
            set;
        }

        public virtual int Choco
        {
            get;
            set;
        }
    }    
}