using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class BananaTopping : ToppingsClass
    {
        SundaeClass currentSundae;

        public BananaTopping(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with a Banana,";
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
