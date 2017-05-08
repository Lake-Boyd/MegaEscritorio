using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mega_Escritorio.Program;

namespace Mega_Escritorio
{




    public partial class Form1 : Form
    {




        double width;
        double depth;

        decimal drawers;

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


            // get the width and depth from the form
            width = (double)deskWidth.Value;
            depth = (double)deskDepth.Value;

            //calcilate the desk area
            double area = Desk.deskArea(width, depth);

            //convert the area to a string and write to the form
            deskArea.Text = area.ToString();

            //get the number of drawers from the form
            drawers = drawerNum.Value;

            //use the desk class to convert to an integer
            int drawerInt = Desk.drawersToInt(drawers);

           

 

            double basePrice = 200;

            double drawerCost = drawerInt * 50;

            double deskAreaPremium = area - 1000;

            if (deskAreaPremium < 0) deskAreaPremium = 0;


            //determine the status of the material selection radio buttons and get a premium

            if (pineRadioButton.Checked) materialPremium = 50.0;

            else if (laminateRadioButton.Checked) materialPremium = 100.0;

            else materialPremium = 200.0;

 
            // determine the status of the shipping radio buttons and get a premium

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


            quote = DeskController.makeQuote(basePrice, deskAreaPremium, drawerCost, materialPremium, shippingPremium);

            priceQuote.Text = "$" + quote.ToString() + ".00";



        }
    }
}
