using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Noah_Hughes_Fan_Club_Fundraiser
{
    public partial class form1 : Form
    {
        //esablish variables
        double amateurPhotosPrice = 2.49;
        double expertPhotosPrice = 7.49;
        double sculpturePrice = 19.99;
        int numAmateurPhotos;
        int numExpertPhotos;
        int numSculptures;
        double amateurPhotos;
        double expertPhotos;
        double sculptures;
        double subTotal;
        double taxRate = 0.13;
        double tax;
        double total;
        double tendered;
        double change;

        //establish soundplayer
        SoundPlayer receiptSound = new SoundPlayer(Properties.Resources.Receipt);


        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                //establish variables
                numAmateurPhotos = Convert.ToInt32(amateurPhotosInput.Text);
                numExpertPhotos = Convert.ToInt32(expertPhotosInput.Text);
                numSculptures = Convert.ToInt32(sculpturesInput.Text);

                amateurPhotos = Convert.ToDouble(amateurPhotosInput.Text) * amateurPhotosPrice;
                expertPhotos = Convert.ToDouble(expertPhotosInput.Text) * expertPhotosPrice;
                sculptures = Convert.ToDouble(sculpturesInput.Text) * sculpturePrice;

                subTotal = amateurPhotos + expertPhotos + sculptures;
                tax = subTotal * taxRate;
                total = subTotal + tax;

                //make tendered visible
                tenderedInput.Visible = true;
                tenderedLabel.Visible = true;
                changeButton.Visible = true;

                //Display totals
                calculateOutput.Text = $"{subTotal.ToString("C")}\n\n{tax.ToString("C")}\n\n{total.ToString("C")}";
                calculateFormat.Text = "Subtotal\n\nTax\n\nTotal";
               

            }
            catch 
            {
                calculateFormat.Text = "ERROR";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //establish new variables
                tendered = Convert.ToDouble(tenderedInput.Text);
                change = tendered - total;

                //output message
                changeLabel.Text = "Cash\n\nChange";
                changeOutput.Text = $"{tendered.ToString("C")}\n\n{change.ToString("C")}";
                
                //make receipt visible
                receiptButton.Visible = true;
                
            }
            catch 
            {
                changeLabel.Text = "ERROR";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            
            //make receipt appear, play sound
            receiptOutput.Visible = true;
            receiptLabel.Visible = true;
            receiptTitle.Visible = true;
            receiptOutput.Text = "";
            receiptLabel.Text = "";
            receiptTitle.Text = "";
            receiptSound.Play();
            Refresh();
            Thread.Sleep(500);

            //print receipt line #1
            receiptTitle.Text = "Noah Hughes Fan Club";
            Refresh();
            Thread.Sleep(650);


            //print receipt line #2
            receiptLabel.Text = $"\n\nAmateur Photos X{numAmateurPhotos}";
            receiptOutput.Text = $"\n\n{amateurPhotos.ToString("C")}";
            Refresh();
            Thread.Sleep(650);

            //print receipt line #3
            receiptLabel.Text += $"\nExpert Photos X{numExpertPhotos}";
            receiptOutput.Text += $"\n{expertPhotos.ToString("C")}";
            Refresh();
            Thread.Sleep(650);

            //print receipt line #4
            receiptLabel.Text += $"\nSculptures X{numSculptures}";
            receiptOutput.Text += $"\n{sculptures.ToString("C")}";
            Refresh();
            Thread.Sleep(650);

            //print receipt line #5
            receiptLabel.Text += $"\n\nSubtotal";
            receiptOutput.Text += $"\n\n{subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(650);

            //print receipt line #6
            receiptLabel.Text += $"\nTax";
            receiptOutput.Text += $"\n{tax.ToString("C")}";
            Refresh();
            Thread.Sleep(650);

            //print receipt line #7
            receiptLabel.Text += $"\nTotal";
            receiptOutput.Text += $"\n{total.ToString("C")}";
            Refresh();
            Thread.Sleep(650);

            //print receipt line #8
            receiptLabel.Text += $"\n\nTendered";
            receiptOutput.Text += $"\n\n{tendered.ToString("C")}";
            Refresh();
            Thread.Sleep(650);

            //print receipt line #9
            receiptLabel.Text += $"\nChange";
            receiptOutput.Text += $"\n{change.ToString("C")}";
            Refresh();
            Thread.Sleep(2250);

            //print receipt line #10
            receiptLabel.Text += $"\n\n               F";
            Refresh();
            Thread.Sleep(250);

            receiptLabel.Text += $"I";
            Refresh();
            Thread.Sleep(250);

            receiptLabel.Text += $"N";
            Refresh();
            Thread.Sleep(250);

            receiptLabel.Text += $"D";
            Refresh();
            Thread.Sleep(250);

            receiptLabel.Text += $" N";
            Refresh();
            Thread.Sleep(250);

            receiptLabel.Text += $"O";
            Refresh();
            Thread.Sleep(250);

            receiptLabel.Text += $"A";
            Refresh();
            Thread.Sleep(250);

            receiptLabel.Text += $"H";
            Refresh();
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //clears order
            amateurPhotosInput.Text = "0";
            expertPhotosInput.Text = "0";
            sculpturesInput.Text = "0";
            calculateFormat.Text = "";
            calculateOutput.Text = "";
            tenderedLabel.Visible = false;
            tenderedInput.Visible = false;
            tenderedInput.Text = "0";
            changeLabel.Text = "";
            changeOutput.Text = "";
            changeButton.Visible = false;
            receiptButton.Visible = false;
            receiptLabel.Text = "";
            receiptOutput.Text = "";
            receiptTitle.Text = "";
            receiptLabel.Visible = false;
            receiptOutput.Visible = false;
            receiptTitle.Visible = false;


        }
    }
}
