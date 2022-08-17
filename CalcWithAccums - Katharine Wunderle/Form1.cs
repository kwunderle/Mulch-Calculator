using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWithAccums___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 02/27/2021
    //Goal: Calculate 
    public partial class mulchCalc : Form
    {
        //Declare constants
        const decimal YARD3 = 27;
        const decimal COST_PER_YD = 17;
        const decimal TRUCK_CAP = 4;
        //Declare user input variables
        decimal lengthInFt;
        decimal widthInFt;
        decimal heightInFt;
        //Declare current order calculation variables
        decimal cubicFt;
        decimal cubicYd;
        decimal orderPrice;
        //Declare total order variables
        decimal totalCubicFt = 0;
        decimal totalCubicYd = 0;
        decimal totalCost = 0;
        int totalOrder = 0;
        //Declare truck variables
        decimal lessOrdered = 0;
        decimal capRemain = 0;

        public mulchCalc()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            //INPUT
            //Get lenght
            lengthInFt = decimal.Parse(lengthInput.Text);
            //Get width
            widthInFt = decimal.Parse(widthInput.Text);
            //Get height
            heightInFt = decimal.Parse(heightInput.Text);

            //PROCESSING
            //Calculate totals of current orders
            //Calculate cubic feet of current order
            cubicFt = lengthInFt * widthInFt * heightInFt;
            //Calculate cubic yards of current order
            cubicYd = cubicFt / YARD3;
            //Calculate price of current order
            orderPrice = cubicYd * COST_PER_YD;

            //Calculate totals of all orders
            totalCubicFt = totalCubicFt + cubicFt;
            totalCubicYd = totalCubicYd + cubicYd;
            totalCost = totalCost + orderPrice;
            totalOrder++;

            //Calculate cubic yards on truck
            lessOrdered += cubicYd;
            //Calculate remaining capacity
            capRemain = TRUCK_CAP - lessOrdered;


            //OUTPUT
            //Current order display
            //Display cubic feet of current order
            cubicFtOutput.Text = cubicFt.ToString("n2");
            //Display cubic yards of current order
            cubicYdOutput.Text = cubicYd.ToString("n2");
            //Display price of current order
            priceOutput.Text = orderPrice.ToString("c");
            //Display price per yard constant
            priceLbl.Text = "@$     " + COST_PER_YD.ToString() + " per Yard";

            //Total of all orders display
            totalCubicFtOutput.Text = totalCubicFt.ToString("n2");
            totalCubicYdOutput.Text = totalCubicYd.ToString("n2");
            totalCostOutput.Text = totalCost.ToString("c");
            totalOrderOutput.Text = totalOrder.ToString();

            //Display maximum truck capacity
            emptyTruckCapOutput.Text = TRUCK_CAP.ToString("n2");
            //Display cubic yards on truck
            lessOrderedOutput.Text = lessOrdered.ToString("n2");
            //Display remaining truck capacity
            truckCapRemainOutput.Text = capRemain.ToString("n2");

            //Highlight remaining capacity text box if greater than 0
            if (capRemain > 0)
            { truckCapRemainOutput.BackColor = Color.LightBlue; }
            else 
            { truckCapRemainOutput.BackColor = Color.Red; }
            //Highlight remaining capacity text box is <= 0

        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clear input text boxes
            lengthInput.Text = "";
            widthInput.Text = "";
            heightInput.Text = "";
            //Clear current order text boxes
            cubicFtOutput.Text = "";
            cubicYdOutput.Text = "";
            priceOutput.Text = "";
            //Clear total text boxes
            totalCubicFtOutput.Text = "";
            totalCubicYdOutput.Text = "";
            totalCostOutput.Text = "";
            totalOrderOutput.Text = "";
            //Reset accumulators
            totalCubicFt = 0;
            totalCubicYd = 0;
            totalCost = 0;
            totalOrder = 0;

            //Clear truck capacity
            emptyTruckCapOutput.Text = "";
            lessOrderedOutput.Text = "";
            truckCapRemainOutput.Text = "";
            //Clear truck capacity accumulators
            lessOrdered = 0;
            capRemain = 0;
            //Clear highlight
            truckCapRemainOutput.BackColor = Color.White;
            
        }
    }
}
