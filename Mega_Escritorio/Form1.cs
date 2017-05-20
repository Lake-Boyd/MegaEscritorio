using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mega_Escritorio.Program;

namespace Mega_Escritorio
{




    public partial class Form : System.Windows.Forms.Form
    {





        double width;
        double depth;

        decimal drawers;

        double materialPremium;
        double shippingPremium;

        double quote;

        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // upon loading the form, count the quotes, determine the maximum number of quotes for the deletQuote form field, show the current date
            int quoteCount = DeskController.countQuotes();
            deleteQuoteNumber.Maximum = quoteCount;
            DateTime now = DateTime.Now;
            quoteDate.Text = now.ToString("d");

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

        public void saveQuote_Click(object sender, EventArgs e)
        {
            errorMessage.Text = "";

            string path;
            path = @"c:\megaescritorio\quotes.txt";
            if (File.Exists(path))
            {

                double area = Desk.deskArea(width, depth);
                string material;
                //determine the status of the material selection radio buttons and get a premium

                if (pineRadioButton.Checked)
                {
                    materialPremium = 50.0;
                    material = "Pine";
                }

                else if (laminateRadioButton.Checked)
                {
                    materialPremium = 100.0;
                    material = "Laminate";
                }

                else
                {
                    materialPremium = 200.0;
                    material = "Oak";
                }


                //determine the status of the shipping terms selection radio buttons and get a premium, select an integer for the terms
                int shippingTerms;
                if (threeDayRadio.Checked)
                {
                    if (area < 1000) shippingPremium = 60;
                    else if ((area >= 1001) && (area <= 1999)) shippingPremium = 70;
                    else shippingPremium = 80;
                    shippingTerms = 3;
                }

                else if (fiveDayRadio.Checked)
                {
                    if (area < 1000) shippingPremium = 40;
                    else if ((area >= 1000) && (area <= 1999)) shippingPremium = 50;
                    else shippingPremium = 60;
                    shippingTerms = 5;
                }

                else if (sevenDayRadio.Checked)
                {
                    if (area < 1000) shippingPremium = 30;
                    else if ((area >= 1001) && (area <= 1999)) shippingPremium = 30;
                    else shippingPremium = 40;
                    shippingTerms = 7;
                }

                else
                {
                    shippingPremium = 0;
                    shippingTerms = 14;
                }

                int drawerInt = Desk.drawersToInt(drawers);

                DeskController.writeQuote(width, depth, drawerInt, material, shippingTerms, quote);

                searchBox.Text = DeskController.buildQuoteSheet();
                int quoteCount = DeskController.countQuotes();
                deleteQuoteNumber.Maximum = quoteCount;
            }

            else
            {
                errorMessage.Text = "Path, c:\\megaescritorio\\quotes.txt does not exist. Trying to create the file. ";

                try
                {
                    StreamWriter writer;
                    writer = new StreamWriter(path);
                    writer.Close();

                }
                catch
                {
                    
                    errorMessage.Text += "...Could not create the file in the path!! Make sure there is a folder called megaescritorio!!";

                }

            }


        }

        public void calcQuote_Click(object sender, EventArgs e)
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

            string material;
            //determine the status of the material selection radio buttons and get a premium

            if (pineRadioButton.Checked)
            {
                materialPremium = 50.0;
                material = "Pine";
            }

            else if (laminateRadioButton.Checked)
            {
                materialPremium = 100.0;
                material = "Laminate";
            }

            else
            {
                materialPremium = 200.0;
                material = "Oak";
            }

            // determine the status of the shipping radio buttons and get a premium
            int shippingTerms;
            if (threeDayRadio.Checked)
                {
                    if (area < 1000) shippingPremium = 60;
                    else if ((area >= 1001) && (area <= 1999)) shippingPremium = 70;
                    else shippingPremium = 80;
                    shippingTerms = 3;
                }

            else if (fiveDayRadio.Checked)
                {
                    if (area < 1000) shippingPremium = 40;
                    else if ((area >= 1000) && (area <= 1999)) shippingPremium = 50;
                    else shippingPremium = 60;
                    shippingTerms = 5;
                }

            else if (sevenDayRadio.Checked)
                {
                    if (area < 1000) shippingPremium = 30;
                    else if ((area >= 1001) && (area <= 1999)) shippingPremium = 30;
                    else shippingPremium = 40;
                    shippingTerms = 7;
                }

            else {
                    shippingPremium = 0;
                    shippingTerms = 14;
                }

 
            // this takes the collected data and computes the quote via the makeQuote method

            quote = DeskController.makeQuote(basePrice, deskAreaPremium, drawerCost, materialPremium, shippingPremium);

            Desk newDesk = new Desk(width, depth, drawerInt, material, shippingTerms, quote);
            Console.WriteLine(newDesk);

            priceQuote.Text = "$" + quote.ToString() + ".00";




        }

        //this refreshes the list of quotes in the window and resets the upper limit for the deleteQuote number.

        private void loadQuotes_Click(object sender, EventArgs e)
        {


            searchBox.Text = DeskController.buildQuoteSheet();
            int quoteCount = DeskController.countQuotes();
            deleteQuoteNumber.Maximum = quoteCount;


        }

        // this searches the quotes file and displays the results in the window

        private void searchMaterial_Click(object sender, EventArgs e)
        {
            string materialName;

            if (pineRadioButton.Checked)
            {
                materialName = "Pine";
            }
            else if (laminateRadioButton.Checked)
            {
                materialName = "Laminate";
            }
            else
            {
                materialName = "Oak";
            }

            searchBox.Text = DeskController.searchQuoteSheet(materialName);



        }


        // this deletes a quote using its listed number to locate its index

        private void deleteQuote_Click(object sender, EventArgs e)

        { 

 
        int quoteNum = Desk.drawersToInt(deleteQuoteNumber.Value);
        int quoteCount = DeskController.countQuotes();

            if (quoteNum <= quoteCount)
            {
                DeskController.deleteQuote(quoteNum);
                searchBox.Text = DeskController.buildQuoteSheet();
                quoteCount = DeskController.countQuotes();
                deleteQuoteNumber.Maximum = quoteCount;
            }
            else
            {

                errorMessage.Text = "Quote number is out of range. Try again.";

            }

        }



    }
}
