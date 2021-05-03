using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        //setup variables
        double baseCost = 7.00;
        double toppingCost = 1.25;
        double toppingCount;
        double totalCost;


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                //get topping count from text box
                toppingCount = Convert.ToDouble(toppingsInput.Text);

                //calculate cost of Pizza with toppings
                totalCost = baseCost + (toppingCount * toppingCost);

                //display total cost
                outputLabel.Text = $"The cost of a pizza with {toppingCount} toppings is {totalCost.ToString("C")}";
            }
            catch
            {
                //send error message
                outputLabel.Text = $"Please enter a valid number of toppings!";
            }



        }
    }
}
