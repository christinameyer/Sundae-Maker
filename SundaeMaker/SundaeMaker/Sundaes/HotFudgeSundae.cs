using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class HotFudgeSundae : SundaeClass
    {
        public HotFudgeSundae()
        {
            description = "Hot Fudge Sundae";
        }

        public override double getCost()
        {
            return 3.00;
        }

        public override int getScoops()
        {
            return 4;
        }
    }
}
