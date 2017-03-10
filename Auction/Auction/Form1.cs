using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        int choice = 1;
        double currentBid = 0;
        

        private void radButton1_CheckedChanged(object sender, EventArgs e)
        {
            //choosing to submit a int
            currentBidLbl.Text = "";
            choice = 1;
            currentBidLbl.Text = String.Format("Current bid:   ") + currentBid.ToString("C");
        }

        private void radButton2_CheckedChanged(object sender, EventArgs e)
        {
            //choosing to submit a double
            currentBidLbl.Text = "";
            choice = 2;
            currentBidLbl.Text = String.Format("Current bid:   ") + currentBid.ToString("C");
        }

        private void radButton3_CheckedChanged(object sender, EventArgs e)
        {
            //choosing to submit a string
            currentBidLbl.Text = "";
            choice = 3;
            currentBidLbl.Text = String.Format("Current bid:   ") + currentBid.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intVal;
            double dblVal;
            string input, strVal;
            input = txtBox1.Text;

            //conversion
            if (choice == 1)
            {
                try
                {
                    string message;
                    intVal = Convert.ToInt32(input);
                    currentBid = Bidding(intVal, out message, currentBid);
                    lblResult.Text = String.Format(message);
                    currentBidLbl.Text = String.Format("Current bid:   ") + currentBid.ToString("C");

                }
                catch
                {
                    lblResult.Text = String.Format("Error: {0}\nEnter in an integer.", input);
                }
            }

            else if(choice == 2)
            {
                try
                {
                    string message;
                    dblVal = Convert.ToDouble(input);
                    currentBid = Bidding(dblVal, out message, currentBid);
                    lblResult.Text = String.Format(message);
                    currentBidLbl.Text = String.Format("Current bid:   ") + currentBid.ToString("C");
                }
                catch
                {
                    lblResult.Text = String.Format("Error: {0}\nEnter in an double.", input);
                }

                
            }

            else if (choice == 3)
            {
                string message;
                strVal = "";

                char [] charArr = new char[input.Length + 7];
                charArr = input.ToCharArray();
                try
                {
                    if (charArr[0] == '$')
                    {
                        for (int i = 1; i < input.Length; i++)
                        {
                            strVal += charArr[i];
                        }
                        strVal.Trim();

                        currentBid = Bidding(strVal, out message, currentBid);
                        lblResult.Text = String.Format(message);
                        currentBidLbl.Text = String.Format("Current bid:   ") + currentBid.ToString("C");

                    }
                    // x-7  x-6   x-5   x-4  x-3  x-2   x-1
                    // D     o     l     l    a    r    s
                    else if (input.Contains("dollars") && charArr[input.Length - 1] == 's')
                    {
                        for (int i = 0; i < input.Length - 7; i++)
                        {
                            strVal += charArr[i];
                        }
                        strVal.Trim();

                        currentBid = Bidding(strVal, out message, currentBid);
                        lblResult.Text = String.Format(message);
                        currentBidLbl.Text = String.Format("Current bid:   ") + currentBid.ToString("C");
                    }
                    else
                    {
                        lblResult.Text = String.Format("Please enter the string in a correct format, as $X.XX or X.XX dollars\n Remember only values greater then $10 accepted.");
                    }
                }
                
                catch
                {
                    lblResult.Text = String.Format("Please enter the string in a correct format, as $X.XX or X.XX dollars\n Remember only values greater then $10 accepted.");
                }
            }

        }

        private static double Bidding(int inVal, out string str, double outVal)
        {
            if (inVal >= 10)
            {
                outVal += Convert.ToDouble(inVal);
                double messageVal = Convert.ToDouble(inVal);
                str = ("You have entered in " + messageVal.ToString("C") +
                    ",\nIt is over the minimum bid of $10.00.\n The Current Bid is now " + outVal.ToString("C"));
                return outVal;
            }
            else
            {
                str = ("You have entered in " + inVal.ToString("C") +
                    ",\nIt is under the minimum bid of $10.\n The Current Bid remains at " + outVal.ToString("C"));
                return outVal;
            }
        }

        private static double Bidding(double inVal, out string str, double outVal)
        {
            if (inVal >= 10)
            {
                outVal += inVal;
                str = ("You have entered in " + inVal.ToString("C") +
                    ",\nIt is over the minimum bid of $10.\n The Current Bid is now " + outVal.ToString("C"));
                return outVal;
            }
            else
            {
                str = ("You have entered in " + inVal.ToString("C") +
                    ",\nIt is under the minimum bid of $10.\n The Current Bid remains at " + outVal.ToString("C"));
                return outVal;
            }
        }

        private static double Bidding(string inVal, out string str, double outVal)
        {
            double strValue = Convert.ToDouble(inVal);

            if (strValue >= 10)
            {
                outVal += strValue;
                str = ("You have entered in " + strValue.ToString("C").Trim() +
                    ",\nIt is over the minimum bid of $10. The Current Bid is now " + outVal.ToString("C"));
                return outVal;
            }
            else
            {
                str = ("You have entered in " + strValue.ToString("C").Trim() +
                    ",\nIt is under the minimum bid of $10. the Current Bid remains at " + outVal.ToString("C"));
                return outVal;
            }
        }

    }
}
