using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SundaeMaker
{
    public class BananaSplit : SundaeClass
    {
        public BananaSplit()
        {
            description = "Banana Split";
        }

        public override double getCost()
        {
            return 4.00;
        }
    }
}
