using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class ChocolateFlavor : IceCreamFlavors
    {
        SundaeClass currentSundae;

        public ChocolateFlavor(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with one scoop of Chocolate,";
        }

        public override double getCost()
        {
            return currentSundae.getCost();
        }
    }
}
