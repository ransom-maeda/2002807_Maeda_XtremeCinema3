using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_XtremeCinema3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        //imports customersServed variable and sets it to 0
        double customersServed = 0;
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                //first groupbox
                double movieCost, totalCost, rentalAmount, movieAmount, discount;
                //assigns values to variables
                discount = 0.1;
                movieCost = 4.50;
                movieAmount = int.Parse(rentedInput.Text);
                rentalAmount = movieCost * movieAmount;
                totalCost = movieAmount - (movieAmount * discount);
                //changes the output of the textboxes
                discountT.Text = "10%";
                rentalAmountT.Text = movieAmount.ToString("C");
                amountDueT.Text = totalCost.ToString("C");
                //second groupbox
                double totalIncome;
                totalIncome = customersServed * totalCost;
                //increments the amount of customers served
                customersServed++;
                //prints the output of the textboxes
                numberServedT.Text = customersServed.ToString();
                totalIncomeT.Text = totalIncome.ToString("C");


            }
            catch
            {
                MessageBox.Show("Please enter a value", "ERROR");
            }


        }

        private void clear_Click(object sender, EventArgs e)
        {

            rentedInput.Clear();
            numberInput.Clear();
            amountDueT.Clear();
            rentalAmountT.Clear();
            discountT.Clear();
        }
    }
}
