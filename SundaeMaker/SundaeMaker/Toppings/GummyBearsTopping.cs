using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class GummyBearsTopping : ToppingsClass
    {
        SundaeClass currentSundae;

        public GummyBearsTopping(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with Gummy Bears,";
        }

        public override double getCost()
        {
            return currentSundae.getCost() + .10;
        }
    }
}
