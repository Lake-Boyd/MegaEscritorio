using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Escritorio
{
    public partial class Form1 : Form
    {

        double width;
        double depth;

        int drawers;

        double materialPremium;
        double shippingPremium;

        double quote;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DrawerNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeskWidth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeskDepth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RushOrderNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deskMaterial_Select(object sender, EventArgs e)
        {

        }

        private void rushOrder_Enter(object sender, EventArgs e)
        {

        }

        private void answer_Enter(object sender, EventArgs e)
        {

        }

        private void saveQuote_Click(object sender, EventArgs e)
        {

        }

        private void calcQuote_Click(object sender, EventArgs e)
        {
            // Calculate the quote



            width = (double)deskWidth.Value;
            depth = (double)deskDepth.Value;

            drawers = Decimal.ToInt32(drawerNum.Value);

            double area = width * depth;

            deskArea.Text = area.ToString();

            double basePrice = 200;

            double drawerCost = drawers * 50;

            double deskAreaPremium = area - 1000;

            if (deskAreaPremium < 0) deskAreaPremium = 0;


            if (pineRadioButton.Checked) materialPremium = 50;

            else if (laminateRadioButton.Checked) materialPremium = 100;

            else materialPremium = 200;

 

            if (threeDayRadio.Checked)
                {
                if (area < 1000) shippingPremium = 60;
                if ((area >= 1001) && (area <= 1999)) shippingPremium = 70;
                if (area >= 2000) shippingPremium = 80;
                }

            else if (fiveDayRadio.Checked)
                {
                    if (area < 1000) shippingPremium = 40;
                    if ((area >= 1000) && (area <= 1999)) shippingPremium = 50;
                    if (area >= 2000) shippingPremium = 60;
                }

            else if (sevenDayRadio.Checked)
                {
                    if (area < 1000) shippingPremium = 30;
                    if ((area >= 1001) && (area <= 1999)) shippingPremium = 30;
                    if (area >= 2000) shippingPremium = 40;
                }

            if (standardRadio.Checked) shippingPremium = 0;


            quote = basePrice + deskAreaPremium + drawerCost + materialPremium + shippingPremium;

            priceQuote.Text = "$" + quote.ToString() + ".00";



        }
    }
}
