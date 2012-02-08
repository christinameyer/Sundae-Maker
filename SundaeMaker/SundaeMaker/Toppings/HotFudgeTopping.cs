using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class HotFudgeTopping : ToppingsClass
    {
        SundaeClass currentSundae;

        public HotFudgeTopping(SundaeClass mySundae)
        {
            this.currentSundae = mySundae;
        }

        public override string getDescription()
        {
            return currentSundae.getDescription() + " with Hot Fudge,";
        }

        public override double getCost()
        {
            return currentSundae.getCost() + .50;
        }

        public override int getScoops()
        {
            return currentSundae.getScoops();
        }
    }
}
