using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class PeanutButterCupFlavor : IceCreamFlavors
    {
        SundaeClass currentSundae;

        public PeanutButterCupFlavor(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with one scoop of Peanut Butter Cup,";
        }

        public override double getCost()
        {
            return currentSundae.getCost();
        }
    }
}
