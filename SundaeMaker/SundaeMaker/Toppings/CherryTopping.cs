using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class CherryTopping : ToppingsClass
    {
        SundaeClass currentSundae;

        public CherryTopping(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with a Cherry,";
        }

        public override double getCost()
        {
            return currentSundae.getCost() + .10;
        }
    }
}
