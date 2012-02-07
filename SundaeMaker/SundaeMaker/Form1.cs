using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SundaeMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SundaeClass myIceCream = new HotFudgeSundae();
            myIceCream = new HotFudgeTopping(myIceCream);
            myIceCream = new PeanutButterCupFlavor(myIceCream);
            label1.Text = myIceCream.getDescription() + " " + myIceCream.getCost();
        }
    }
}
