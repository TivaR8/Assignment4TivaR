using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 19-03-2018
 * Created for: ICS3U Programming
 * Assignment #4b - Assignment 4
 * This program calculates the price of a pizza...
 * ... based on the choices of the user
*/

namespace Assignment4TivaR
{
    public partial class Assignment4Form : Form
    {
        // Constant of HST
            const double HST = 0.13;

            // Constants for Pizza Sizes
            const double smallPizza = 7.99;
            const double largePizza = 9.99;
            const double extraLargePizza = 12.99;

            // Constants for # of Toppings
            const double oneTopping = 0.75;
            const double twoToppings = 1.35;
            const double threeToppings = 2.15;
            const double fourToppings = 2.75;

            //Constants for Soda
            const double sodaCostYes = 2.50;
            const double sodaCostNo = 0;

            // Constant for Discount code
            const string discountCode = "pizzza";

        public Assignment4Form()
        {
            InitializeComponent();

            // Hide the Final cost items
            this.lblHST.Hide();
            this.lblSubtotal.Hide();
            this.lblTotalCost.Show();
            
        }

        private void nudSizeSelection_ValueChanged(object sender, EventArgs e)
        {
            //To disable the second phase of things
            this.txtDiscount.Enabled = false;
            this.lblDiscountQuestion.Enabled = false;

            // Hide the Final cost items
            this.lblHST.Hide();
            this.lblSubtotal.Hide();
            this.lblTotalCost.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // To set a variable to hold all of the Selections
            double size, toppings, subtotal, soda, totalCost;

            // To determine what size the user wants
            if (nudSizeSelection.Value == 1)
            {
                size = smallPizza;
            }
            else if (nudSizeSelection.Value == 2)
            {
                size = largePizza;
            }
            else
            {
                size = extraLargePizza;
            }
     
            // To determine how many toppings the user wants
            if (nudToppingsSelection.Value == 1)
            {
                toppings = oneTopping;
            }
            else if (nudToppingsSelection.Value == 2)
            {
                toppings = twoToppings;
            }
            else if (nudToppingsSelection.Value == 3)
            {
                toppings = threeToppings;
            }
            else
            {
                toppings = fourToppings;
            }

            // To determine if user selected a soda
            if (radSodaNo.Checked == true)
            {
                soda = sodaCostYes;
            }
            else
            {
                soda = sodaCostNo;
            }

            // The Calculation of the Subtotal
            subtotal = (size + toppings + soda);

            // Display subtotal
            lblSubtotal.Text = ("Subtotal = $"+subtotal);

            // To let the user enter the discount code.
            this.txtDiscount.Enabled = true;
            this.lblDiscountQuestion.Enabled = true;


            this.grbSize.Enabled = false;
            this.grbToppings.Enabled = false;
            this.grbSoda.Enabled = false;

            //This section is what I call...
            //...phase two
            // It will handle all of the discount stuff
            //***********************************************************************************

            // This shows new text on the discount option
            btnOrder.Text = ("Enter discount code");
            // Variables
            string usersCode;

            // Set the users code to what was entered in the text box
            usersCode = (txtDiscount.Text);

            // Is the entered code correct?
            if (usersCode == discountCode)
            {
                subtotal = (subtotal - (subtotal * 0.15));
            }
                //To calculate final total cost
            totalCost = subtotal * HST;

            // To Set all of the labels to the correct amount
            lblSubtotal.Text = ("Subtotal = $" + subtotal);
            lblTotalCost.Text = ("Total Cost = $" + totalCost);
            lblHST.Text = ("HST is " + HST + "%");

            //To display final cost subtotal and everything
            this.lblTotalCost.Show();
            this.lblSubtotal.Show();
            this.lblHST.Show();


        }

        private void nudToppingsSelection_ValueChanged(object sender, EventArgs e)
        {
            this.txtDiscount.Enabled = false;
            this.lblDiscountQuestion.Enabled = false;
        }

        private void radSodaYes_CheckedChanged(object sender, EventArgs e)
        {
            this.txtDiscount.Enabled = false;
            this.lblDiscountQuestion.Enabled = false;
        }

        private void radSodaNo_CheckedChanged(object sender, EventArgs e)
        {
            this.txtDiscount.Enabled = false;
            this.lblDiscountQuestion.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Enable and disable everything like it was in the beginning
            this.txtDiscount.Enabled = false;
            this.lblDiscountQuestion.Enabled = false;

            this.grbSize.Enabled = true;
            this.grbToppings.Enabled = true;
            this.grbSoda.Enabled = true;

            //Set all of the Numerical counters to one 
            this.nudSizeSelection.Value = 1;
            this.nudToppingsSelection.Value = 1;
            this.radSodaNo.Checked = true;

            //SHide all of the Costs 
            this.lblHST.Hide();
            this.lblSubtotal.Hide();
            this.lblTotalCost.Hide();


        }


    }
}
