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
        SundaeClass SundaeTime;
        int scoops;
        
        public Form1()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            button1.Visible = false;
            button8.Visible = false;
            label1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public SundaeClass SundaeCreator(int Type)
        {
            if (Type == 1)
            {
                SundaeClass myIceCream = new BananaSplit();
                myIceCream = new BananaTopping(myIceCream);
                myIceCream = new CherryTopping(myIceCream);
                myIceCream = new WhippedCreamTopping(myIceCream);
                return myIceCream;
            }
            else if (Type == 2)
            {
                SundaeClass myIceCream = new HotFudgeSundae();
                myIceCream = new HotFudgeTopping(myIceCream);
                return myIceCream;
            }
            else
            {
                SundaeClass myIceCream = new LargeCone();
                return myIceCream;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                SundaeTime = SundaeCreator(1);
            }
            else if (radioButton2.Checked == true)
            {
                SundaeTime = SundaeCreator(2);
            }
            else
            {
                SundaeTime = SundaeCreator(3);
            }

            Window2();
        }

        public void Window2()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            button1.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            label1.Visible = true;
            scoops = SundaeTime.getScoops();
            labelUpdate();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void labelUpdate()
        {
            label1.Text = "Remaining scoops: " + scoops;
            label2.Text = " " + SundaeTime.getDescription() +" Cost:" +  SundaeTime.getCost();
        }

        private void button2_Click(object sender, EventArgs e)  // Chocolate
        {
            SundaeTime = new ChocolateFlavor(SundaeTime);
            scoops -= 1;

            if (scoops == 0)
            {
                Window3();
            }

            else
            {
                labelUpdate();
            }
        }

        private void button3_Click(object sender, EventArgs e)  // Coffee
        {
            SundaeTime = new CoffeeFlavor(SundaeTime);
            scoops -= 1;

            if (scoops == 0)
            {
                Window3();
            }

            else
            {
                labelUpdate();
            }
        }

        private void button4_Click(object sender, EventArgs e)  // Cookie Dough
        {
            SundaeTime = new CookieDoughFlavor(SundaeTime);
            scoops -= 1;

            if (scoops == 0)
            {
                Window3();
            }

            else
            {
                labelUpdate();
            }
        }

        private void button5_Click(object sender, EventArgs e)  // PB Cup
        {
            SundaeTime = new PeanutButterCupFlavor(SundaeTime);
            scoops -= 1;

            if (scoops == 0)
            {
                Window3();
            }

            else
            {
                labelUpdate();
            }
        }

        private void button6_Click(object sender, EventArgs e)  // Strawberry
        {
            SundaeTime = new StrawberryFlavor(SundaeTime);
            scoops -= 1;

            if (scoops == 0)
            {
                Window3();
            }

            else
            {
                labelUpdate();
            }
        }

        public void Window3()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            button1.Visible = false;
            button7.Visible = false;
            button8.Visible = true;
            label1.Visible = false;
            labelUpdate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                SundaeTime = new BananaTopping(SundaeTime);
            }

            if (checkBox7.Checked == true)
            {
                SundaeTime = new CherryTopping(SundaeTime);
            }

            if (checkBox8.Checked == true)
            {
                SundaeTime = new ChocolateSprinklesTopping(SundaeTime);
            }

            if (checkBox9.Checked == true)
            {
                SundaeTime = new GummyBearsTopping(SundaeTime);
            }

            if (checkBox10.Checked == true)
            {
                SundaeTime = new HotFudgeTopping(SundaeTime);
            }

            if (checkBox11.Checked == true)
            {
                SundaeTime = new ReesesPiecesTopping(SundaeTime);
            }

            if (checkBox12.Checked == true)
            {
                SundaeTime = new WhippedCreamTopping(SundaeTime);
            }

            labelUpdate();
        }
    }
}
