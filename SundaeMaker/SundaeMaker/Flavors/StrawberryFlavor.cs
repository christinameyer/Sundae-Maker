using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class StrawberryFlavor : IceCreamFlavors
    {
        SundaeClass currentSundae;

        public StrawberryFlavor(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with one scoop of Strawberry,";
        }

        public override double getCost()
        {
            return currentSundae.getCost();
        }

        public override int getScoops()
        {
            return currentSundae.getScoops();
        }
    }
}
