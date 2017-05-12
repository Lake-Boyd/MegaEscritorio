using Microsoft.SqlServer.Server;
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
            double deskWidth = 0;
            double deskDepth = 0;
            int drawerNum = 0;
            string deskMaterial = "";
            int shipTerms = 0;
            double deskQuote = 0;

            public Desk (double inDeskWidth, double inDeskDepth, int inDrawerNum, string inDeskMaterial, int inShipTerms, double inDeskQuote)
            {
                deskWidth = inDeskWidth;
                deskDepth = inDeskDepth;
                drawerNum = inDrawerNum;
                deskMaterial = inDeskMaterial;
                shipTerms = inShipTerms;
                deskQuote = inDeskQuote;

            }

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

                try
                {

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

                    foreach (string line in fileStrings)
                    {
                        writer.WriteLine(line);

                    }
                    writer.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }


            }


            public static double makeQuote(double x, double y, double z, double i, double j )
            {
                double quote = 0;
                try
                {
                    quote = x + y + z + i + j;

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return quote;

            }


            public static string buildQuoteSheet()
            {
                string text = null;

                try
                {

                    string path;
                    path = @"c:\megaescritorio\quotes.txt";

                    StreamReader reader = new StreamReader(path);

                    ArrayList quoteList = new ArrayList();

                    int i = -1;
                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        i++;
                        quoteList.Add(line);
                    }
                    reader.Close();

                    text = "Num\tMaterial\tWidth\tDepth\tDrawers\tShipping\tQuote\tDate" + Environment.NewLine;
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
 
                        }

                        text += pcounterString + paramString + Environment.NewLine;
                        pcounter++;

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }


                return text;

            }


            public static string searchQuoteSheet( string materialName)
            {
                string text = null;

                try
                {
                    string path;
                    path = @"c:\megaescritorio\quotes.txt";

                    StreamReader reader = new StreamReader(path);

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


                    text = "Material\tWidth\tDepth\tDrawers\tShipping\tQuote\tDate" + Environment.NewLine;
                    int pcounter = 0;
                    foreach (string row in quoteList)
                    {
                        string[] results = row.Split(',');

                       // string pcounterString;
                        string paramString = "";
                        // pcounterString = pcounter.ToString() + ":\t";
                        foreach (string param in results)
                        {

                            paramString += param + "\t";

                        }

                        text += paramString + Environment.NewLine;
                        pcounter++;

                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }

                return text;

            }


            public static void deleteQuote(int quoteNum)
                {

                string path;
                path = @"c:\megaescritorio\quotes.txt";
                try
                {

                    StreamReader reader = new StreamReader(path);


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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }





            }

            public static int countQuotes()
            {
                int i =0;
                try
                {

                    string path;
                    path = @"c:\megaescritorio\quotes.txt";

                    StreamReader reader = new StreamReader(path);

                    i = -1;

                    while (reader.EndOfStream == false)
                    {
                        string line = reader.ReadLine();
                        i++;
                    }
                    reader.Close();

 
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return i;

            }



        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
