using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class LargeCone : SundaeClass
    {
        public LargeCone()
        {
            description = "Large Cone";
        }

        public override double getCost()
        {
            return 2.00;
        }
    }
}
