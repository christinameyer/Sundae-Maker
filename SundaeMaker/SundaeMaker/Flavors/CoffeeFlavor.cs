using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class CoffeeFlavor : IceCreamFlavors
    {
        SundaeClass currentSundae;

        public CoffeeFlavor(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with one scoop of Coffee,";
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
