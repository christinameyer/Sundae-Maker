using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public abstract class SundaeClass
    {
        public string description = " ";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract double getCost();

        public abstract int getScoops();
    }

}


