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


            public static string buildQuoteSheet()
            {

                string path;
                path = @"c:\megaescritorio\quotes.txt";

                StreamReader reader = new StreamReader(path);

                //  string[] quoteList = new string[];

                ArrayList quoteList = new ArrayList();

                int i = -1;
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    i++;
                    quoteList.Add(line);
                }
                reader.Close();

                // int j = 6;
                // string[,] quotesArray = new string[j, i];
                // int counter = 0;
                string text = "Num\tMaterial\tWidth\tDepth\tDrawers\tShipping\tQuote\tDate" + Environment.NewLine;
                int pcounter = 0;
                foreach (string row in quoteList)
                {
                    string[] results = row.Split(',');


                    string pcounterString;
                    string paramString = "";
                    pcounterString = pcounter.ToString() + ":\t";
                    foreach (string param in results)
                    {

                        paramString += param + "\t";
                        //      quotesArray[counter, pcounter] = param;

                    }

                    text += pcounterString + paramString + Environment.NewLine;
                    pcounter++;
                    //    counter++;


                }

                return text;

            }


            public static string searchQuoteSheet( string materialName)
            {

                string path;
                path = @"c:\megaescritorio\quotes.txt";

                StreamReader reader = new StreamReader(path);

                //  string[] quoteList = new string[];

                ArrayList quoteList = new ArrayList();

                int i = -1;
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    i++;

                    if (line.StartsWith(materialName))
                    {
                        quoteList.Add(line);
                    }


                }
                reader.Close();

                // int j = 6;
                // string[,] quotesArray = new string[j, i];
                // int counter = 0;
                string text = "Num\tMaterial\tWidth\tDepth\tDrawers\tShipping\tQuote\tDate" + Environment.NewLine;
                int pcounter = 0;
                foreach (string row in quoteList)
                {
                    string[] results = row.Split(',');


                    string pcounterString;
                    string paramString = "";
                    pcounterString = pcounter.ToString() + ":\t";
                    foreach (string param in results)
                    {

                        paramString += param + "\t";
                        //      quotesArray[counter, pcounter] = param;

                    }

                    text += pcounterString + paramString + Environment.NewLine;
                    pcounter++;
                    //    counter++;


                }

                return text;



            }


            public static void deleteQuote(int quoteNum)
                {

                string path;
                path = @"c:\megaescritorio\quotes.txt";

                StreamReader reader = new StreamReader(path);

                //  string[] quoteList = new string[];

                ArrayList quoteList = new ArrayList();

                int i = -1;
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    i++;

                    if (i != quoteNum)
                    {
                        quoteList.Add(line);
                    }


                }
                reader.Close();

                StreamWriter writer = new StreamWriter(path);

                foreach (string row in quoteList)
                {
                    writer.WriteLine(row);

                }

                writer.Close();


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
