using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesPracticeCSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) //button
        {
            string playerName;
            int playerNumber;

            playerName = "Wayne Gretzky";
            playerNumber = 99;

            outputLabel.Text = playerName + " is number " + playerNumber;
        }

        private void CircleArea_Click(object sender, EventArgs e)
        {
            double radius, pi, area;

            radius = 15;
            pi = 3.14;

            area = pi * radius * radius;

            outputLabel.Text = "The area of a circle with a radius of " + radius + "cm is " + area + "cm^2";
        }


        private void BillButton_Click(object sender, EventArgs e)
        {
            double shirtPrice, moneyPaid, tax, totalBill, change;

            shirtPrice = 12.49;
            moneyPaid = 20;

            tax = shirtPrice * 0.13;
            totalBill = shirtPrice + tax;
            change = moneyPaid - totalBill;

            outputLabel.Text = $"Bill of Sale \n \n Shirt:  {shirtPrice} \n \n Tax:  {tax} \n Total:  {totalBill} \n \n Tendered:  {moneyPaid} \n Change:  {change}";
        }


        private void CarpetButton_Click(object sender, EventArgs e)
        {
            double length, width, costPerMeter, area, totalCost;

            length = 8.5;
            width = 6;
            costPerMeter = 19.95;

            area = length * width;
            totalCost = area * costPerMeter;

            outputLabel.Text = $"The area of a room with dimensions {length}m x {width}m is {area}m^2 \n \n The cost to carpet this area at {costPerMeter} per square metre is ${totalCost}";
        }
    }
}
