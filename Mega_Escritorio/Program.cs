using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Escritorio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public class Desk
        {



            public static double deskArea(double width, double depth)
            {

                double area = width * depth;
                return area;

            }

            public static int drawersToInt(decimal drawers)
            {
                int drawerInt = Decimal.ToInt32(drawers);
                return drawerInt;

            }


        }

        public class DeskController
        {

            internal static void writeQuote( double width, double depth, int drawers, string material, int shipTerms, double quote)
            {

                string path;
                path = @"c:\megaescritorio\quotes.txt";

                StreamReader reader = new StreamReader(path);

                List<string> fileStrings = new List<string>();

                while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        fileStrings.Add(line);
                    }
                reader.Close();

                string writeWidth = System.Convert.ToString(width);
                string writeDepth = System.Convert.ToString(depth);
                string writeDrawerNumber = System.Convert.ToString(drawers);
                string writeShipTerms = System.Convert.ToString(shipTerms);
                string writeQuote = System.Convert.ToString(quote);
                DateTime now = DateTime.Now;
                string writeDate = now.ToString("d");

                string quoteLine = material + "," + writeWidth + "," + writeDepth + "," + writeDrawerNumber + "," + writeShipTerms + "," + writeQuote + "," + writeDate;

                fileStrings.Add(quoteLine);

                StreamWriter writer;
                writer = new StreamWriter(path);

                foreach ( string line in fileStrings)
                    {
                        writer.WriteLine(line);

                    }
                writer.Close();



            }


            public static double makeQuote(double x, double y, double z, double i, double j )
            {


                double quote = x + y + z + i + j;
                return quote;

            }


            public static void buildQuoteSheet()
            {






            }





        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
