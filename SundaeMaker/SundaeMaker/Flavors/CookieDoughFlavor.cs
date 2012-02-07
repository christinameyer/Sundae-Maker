using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class CookieDoughFlavor : IceCreamFlavors
    {
        SundaeClass currentSundae;

        public CookieDoughFlavor(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with one scoop of Cookie Dough,";
        }

        public override double getCost()
        {
            return currentSundae.getCost();
        }
    }
}
