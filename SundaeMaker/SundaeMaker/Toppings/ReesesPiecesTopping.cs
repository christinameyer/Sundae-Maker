using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class ReesesPiecesTopping : ToppingsClass
    {
        SundaeClass currentSundae;

        public ReesesPiecesTopping(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with Reeses Pieces,";
        }

        public override double getCost()
        {
            return currentSundae.getCost() + .10;
        }

        public override int getScoops()
        {
            return currentSundae.getScoops();
        }
    }
}
