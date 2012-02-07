using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class ChocolateSprinklesTopping : ToppingsClass
    {
        SundaeClass currentSundae;

        public ChocolateSprinklesTopping(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with Chocolate Sprinkles,";
        }

        public override double getCost()
        {
            return currentSundae.getCost() + .10;
        }
    }
}
