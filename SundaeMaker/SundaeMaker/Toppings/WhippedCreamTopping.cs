using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class WhippedCreamTopping : ToppingsClass
    {
        SundaeClass currentSundae;

        public WhippedCreamTopping(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with Whipped Cream,";
        }

        public override double getCost()
        {
            return currentSundae.getCost() + .30;
        }
    }
}
