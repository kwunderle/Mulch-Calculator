
namespace CalcWithAccums___Katharine_Wunderle
{
    partial class mulchCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mulchCalcLbl = new System.Windows.Forms.Label();
            this.enterLengthLbl = new System.Windows.Forms.Label();
            this.enterWidthLbl = new System.Windows.Forms.Label();
            this.enterHeightLbl = new System.Windows.Forms.Label();
            this.lengthInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.currentOrderBox = new System.Windows.Forms.GroupBox();
            this.priceOutput = new System.Windows.Forms.Label();
            this.cubicYdOutput = new System.Windows.Forms.Label();
            this.cubicFtOutput = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.cubicYdLbl = new System.Windows.Forms.Label();
            this.cubicFtLbl = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.GroupBox();
            this.totalOrderOutput = new System.Windows.Forms.Label();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.totalCubicYdOutput = new System.Windows.Forms.Label();
            this.totalCubicFtOutput = new System.Windows.Forms.Label();
            this.totalOrderLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.totalCubicYdLbl = new System.Windows.Forms.Label();
            this.totalCubicFtLbl = new System.Windows.Forms.Label();
            this.emptyTruckCapLbl = new System.Windows.Forms.Label();
            this.emptyTruckCapOutput = new System.Windows.Forms.Label();
            this.lessOrderedLbl = new System.Windows.Forms.Label();
            this.lessOrderedOutput = new System.Windows.Forms.Label();
            this.truckCapRemainLbl = new System.Windows.Forms.Label();
            this.truckCapRemainOutput = new System.Windows.Forms.Label();
            this.clrBtn = new System.Windows.Forms.Button();
            this.katieCo = new System.Windows.Forms.Label();
            this.currentOrderBox.SuspendLayout();
            this.totalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mulchCalcLbl
            // 
            this.mulchCalcLbl.AutoSize = true;
            this.mulchCalcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulchCalcLbl.Location = new System.Drawing.Point(66, 2);
            this.mulchCalcLbl.Name = "mulchCalcLbl";
            this.mulchCalcLbl.Size = new System.Drawing.Size(135, 13);
            this.mulchCalcLbl.TabIndex = 1;
            this.mulchCalcLbl.Text = "MULCH CALCULATOR";
            // 
            // enterLengthLbl
            // 
            this.enterLengthLbl.AutoSize = true;
            this.enterLengthLbl.Location = new System.Drawing.Point(42, 21);
            this.enterLengthLbl.Name = "enterLengthLbl";
            this.enterLengthLbl.Size = new System.Drawing.Size(83, 13);
            this.enterLengthLbl.TabIndex = 2;
            this.enterLengthLbl.Text = "Enter Length (ft)";
            // 
            // enterWidthLbl
            // 
            this.enterWidthLbl.AutoSize = true;
            this.enterWidthLbl.Location = new System.Drawing.Point(42, 47);
            this.enterWidthLbl.Name = "enterWidthLbl";
            this.enterWidthLbl.Size = new System.Drawing.Size(78, 13);
            this.enterWidthLbl.TabIndex = 3;
            this.enterWidthLbl.Text = "Enter Width (ft)";
            // 
            // enterHeightLbl
            // 
            this.enterHeightLbl.AutoSize = true;
            this.enterHeightLbl.Location = new System.Drawing.Point(42, 73);
            this.enterHeightLbl.Name = "enterHeightLbl";
            this.enterHeightLbl.Size = new System.Drawing.Size(81, 13);
            this.enterHeightLbl.TabIndex = 4;
            this.enterHeightLbl.Text = "Enter Height (ft)";
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(143, 18);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(69, 20);
            this.lengthInput.TabIndex = 5;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(143, 44);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(69, 20);
            this.widthInput.TabIndex = 6;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(143, 70);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(69, 20);
            this.heightInput.TabIndex = 7;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(45, 96);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(167, 23);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // currentOrderBox
            // 
            this.currentOrderBox.Controls.Add(this.priceOutput);
            this.currentOrderBox.Controls.Add(this.cubicYdOutput);
            this.currentOrderBox.Controls.Add(this.cubicFtOutput);
            this.currentOrderBox.Controls.Add(this.priceLbl);
            this.currentOrderBox.Controls.Add(this.cubicYdLbl);
            this.currentOrderBox.Controls.Add(this.cubicFtLbl);
            this.currentOrderBox.Location = new System.Drawing.Point(12, 125);
            this.currentOrderBox.Name = "currentOrderBox";
            this.currentOrderBox.Size = new System.Drawing.Size(200, 141);
            this.currentOrderBox.TabIndex = 9;
            this.currentOrderBox.TabStop = false;
            this.currentOrderBox.Text = "Current Order";
            // 
            // priceOutput
            // 
            this.priceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceOutput.Location = new System.Drawing.Point(114, 97);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.Size = new System.Drawing.Size(66, 23);
            this.priceOutput.TabIndex = 5;
            this.priceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cubicYdOutput
            // 
            this.cubicYdOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cubicYdOutput.Location = new System.Drawing.Point(114, 63);
            this.cubicYdOutput.Name = "cubicYdOutput";
            this.cubicYdOutput.Size = new System.Drawing.Size(66, 23);
            this.cubicYdOutput.TabIndex = 4;
            this.cubicYdOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cubicFtOutput
            // 
            this.cubicFtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cubicFtOutput.Location = new System.Drawing.Point(114, 28);
            this.cubicFtOutput.Name = "cubicFtOutput";
            this.cubicFtOutput.Size = new System.Drawing.Size(66, 23);
            this.cubicFtOutput.TabIndex = 3;
            this.cubicFtOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(11, 102);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(60, 13);
            this.priceLbl.TabIndex = 2;
            this.priceLbl.Text = "@$    Price";
            // 
            // cubicYdLbl
            // 
            this.cubicYdLbl.AutoSize = true;
            this.cubicYdLbl.Location = new System.Drawing.Point(11, 68);
            this.cubicYdLbl.Name = "cubicYdLbl";
            this.cubicYdLbl.Size = new System.Drawing.Size(64, 13);
            this.cubicYdLbl.TabIndex = 1;
            this.cubicYdLbl.Text = "Cubic Yards";
            // 
            // cubicFtLbl
            // 
            this.cubicFtLbl.AutoSize = true;
            this.cubicFtLbl.Location = new System.Drawing.Point(17, 33);
            this.cubicFtLbl.Name = "cubicFtLbl";
            this.cubicFtLbl.Size = new System.Drawing.Size(58, 13);
            this.cubicFtLbl.TabIndex = 0;
            this.cubicFtLbl.Text = "Cubic Feet";
            // 
            // totalBox
            // 
            this.totalBox.Controls.Add(this.totalOrderOutput);
            this.totalBox.Controls.Add(this.totalCostOutput);
            this.totalBox.Controls.Add(this.totalCubicYdOutput);
            this.totalBox.Controls.Add(this.totalCubicFtOutput);
            this.totalBox.Controls.Add(this.totalOrderLbl);
            this.totalBox.Controls.Add(this.totalCostLbl);
            this.totalBox.Controls.Add(this.totalCubicYdLbl);
            this.totalBox.Controls.Add(this.totalCubicFtLbl);
            this.totalBox.Location = new System.Drawing.Point(218, 125);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(200, 141);
            this.totalBox.TabIndex = 0;
            this.totalBox.TabStop = false;
            this.totalBox.Text = "Total of All Orders";
            // 
            // totalOrderOutput
            // 
            this.totalOrderOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOrderOutput.Location = new System.Drawing.Point(128, 115);
            this.totalOrderOutput.Name = "totalOrderOutput";
            this.totalOrderOutput.Size = new System.Drawing.Size(66, 23);
            this.totalOrderOutput.TabIndex = 7;
            this.totalOrderOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutput.Location = new System.Drawing.Point(128, 87);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(66, 23);
            this.totalCostOutput.TabIndex = 6;
            this.totalCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCubicYdOutput
            // 
            this.totalCubicYdOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCubicYdOutput.Location = new System.Drawing.Point(128, 58);
            this.totalCubicYdOutput.Name = "totalCubicYdOutput";
            this.totalCubicYdOutput.Size = new System.Drawing.Size(66, 23);
            this.totalCubicYdOutput.TabIndex = 5;
            this.totalCubicYdOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCubicFtOutput
            // 
            this.totalCubicFtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCubicFtOutput.Location = new System.Drawing.Point(128, 28);
            this.totalCubicFtOutput.Name = "totalCubicFtOutput";
            this.totalCubicFtOutput.Size = new System.Drawing.Size(66, 23);
            this.totalCubicFtOutput.TabIndex = 4;
            this.totalCubicFtOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalOrderLbl
            // 
            this.totalOrderLbl.AutoSize = true;
            this.totalOrderLbl.Location = new System.Drawing.Point(34, 120);
            this.totalOrderLbl.Name = "totalOrderLbl";
            this.totalOrderLbl.Size = new System.Drawing.Size(90, 13);
            this.totalOrderLbl.TabIndex = 3;
            this.totalOrderLbl.Text = "Number of Orders";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Location = new System.Drawing.Point(42, 92);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(82, 13);
            this.totalCostLbl.TabIndex = 2;
            this.totalCostLbl.Text = "Cost (All Orders)";
            // 
            // totalCubicYdLbl
            // 
            this.totalCubicYdLbl.AutoSize = true;
            this.totalCubicYdLbl.Location = new System.Drawing.Point(6, 63);
            this.totalCubicYdLbl.Name = "totalCubicYdLbl";
            this.totalCubicYdLbl.Size = new System.Drawing.Size(118, 13);
            this.totalCubicYdLbl.TabIndex = 1;
            this.totalCubicYdLbl.Text = "Cubic Yards (All Orders)";
            // 
            // totalCubicFtLbl
            // 
            this.totalCubicFtLbl.AutoSize = true;
            this.totalCubicFtLbl.Location = new System.Drawing.Point(12, 33);
            this.totalCubicFtLbl.Name = "totalCubicFtLbl";
            this.totalCubicFtLbl.Size = new System.Drawing.Size(112, 13);
            this.totalCubicFtLbl.TabIndex = 0;
            this.totalCubicFtLbl.Text = "Cubic Feet (All Orders)";
            // 
            // emptyTruckCapLbl
            // 
            this.emptyTruckCapLbl.AutoSize = true;
            this.emptyTruckCapLbl.Location = new System.Drawing.Point(23, 274);
            this.emptyTruckCapLbl.Name = "emptyTruckCapLbl";
            this.emptyTruckCapLbl.Size = new System.Drawing.Size(67, 39);
            this.emptyTruckCapLbl.TabIndex = 10;
            this.emptyTruckCapLbl.Text = "Empty Truck\r\nCapacity\r\n(cubic yards)";
            this.emptyTruckCapLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emptyTruckCapOutput
            // 
            this.emptyTruckCapOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emptyTruckCapOutput.Location = new System.Drawing.Point(96, 282);
            this.emptyTruckCapOutput.Name = "emptyTruckCapOutput";
            this.emptyTruckCapOutput.Size = new System.Drawing.Size(66, 23);
            this.emptyTruckCapOutput.TabIndex = 11;
            this.emptyTruckCapOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lessOrderedLbl
            // 
            this.lessOrderedLbl.AutoSize = true;
            this.lessOrderedLbl.Location = new System.Drawing.Point(181, 274);
            this.lessOrderedLbl.Name = "lessOrderedLbl";
            this.lessOrderedLbl.Size = new System.Drawing.Size(70, 39);
            this.lessOrderedLbl.TabIndex = 12;
            this.lessOrderedLbl.Text = "Less:\r\nOrdered\r\n(Cubic Yards)";
            this.lessOrderedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lessOrderedOutput
            // 
            this.lessOrderedOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lessOrderedOutput.Location = new System.Drawing.Point(255, 282);
            this.lessOrderedOutput.Name = "lessOrderedOutput";
            this.lessOrderedOutput.Size = new System.Drawing.Size(66, 23);
            this.lessOrderedOutput.TabIndex = 13;
            this.lessOrderedOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // truckCapRemainLbl
            // 
            this.truckCapRemainLbl.AutoSize = true;
            this.truckCapRemainLbl.Location = new System.Drawing.Point(355, 269);
            this.truckCapRemainLbl.Name = "truckCapRemainLbl";
            this.truckCapRemainLbl.Size = new System.Drawing.Size(57, 52);
            this.truckCapRemainLbl.TabIndex = 14;
            this.truckCapRemainLbl.Text = "Equals:\r\nTruck\r\nCapacity\r\nRemaining";
            this.truckCapRemainLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // truckCapRemainOutput
            // 
            this.truckCapRemainOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.truckCapRemainOutput.Location = new System.Drawing.Point(418, 282);
            this.truckCapRemainOutput.Name = "truckCapRemainOutput";
            this.truckCapRemainOutput.Size = new System.Drawing.Size(66, 23);
            this.truckCapRemainOutput.TabIndex = 15;
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(171, 322);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(171, 23);
            this.clrBtn.TabIndex = 16;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // katieCo
            // 
            this.katieCo.AutoSize = true;
            this.katieCo.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.katieCo.Location = new System.Drawing.Point(242, 38);
            this.katieCo.Name = "katieCo";
            this.katieCo.Size = new System.Drawing.Size(255, 48);
            this.katieCo.TabIndex = 6;
            this.katieCo.Text = "Katharine Wunderle\r\nLandscaping Company";
            this.katieCo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulchCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 347);
            this.Controls.Add(this.katieCo);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.truckCapRemainOutput);
            this.Controls.Add(this.truckCapRemainLbl);
            this.Controls.Add(this.lessOrderedOutput);
            this.Controls.Add(this.lessOrderedLbl);
            this.Controls.Add(this.emptyTruckCapOutput);
            this.Controls.Add(this.emptyTruckCapLbl);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.currentOrderBox);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.lengthInput);
            this.Controls.Add(this.enterHeightLbl);
            this.Controls.Add(this.enterWidthLbl);
            this.Controls.Add(this.enterLengthLbl);
            this.Controls.Add(this.mulchCalcLbl);
            this.Name = "mulchCalc";
            this.Text = "Mulch Calculator";
            this.currentOrderBox.ResumeLayout(false);
            this.currentOrderBox.PerformLayout();
            this.totalBox.ResumeLayout(false);
            this.totalBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mulchCalcLbl;
        private System.Windows.Forms.Label enterLengthLbl;
        private System.Windows.Forms.Label enterWidthLbl;
        private System.Windows.Forms.Label enterHeightLbl;
        private System.Windows.Forms.TextBox lengthInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.GroupBox currentOrderBox;
        private System.Windows.Forms.Label priceOutput;
        private System.Windows.Forms.Label cubicYdOutput;
        private System.Windows.Forms.Label cubicFtOutput;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label cubicYdLbl;
        private System.Windows.Forms.Label cubicFtLbl;
        private System.Windows.Forms.GroupBox totalBox;
        private System.Windows.Forms.Label totalOrderOutput;
        private System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label totalCubicYdOutput;
        private System.Windows.Forms.Label totalCubicFtOutput;
        private System.Windows.Forms.Label totalOrderLbl;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label totalCubicYdLbl;
        private System.Windows.Forms.Label totalCubicFtLbl;
        private System.Windows.Forms.Label emptyTruckCapLbl;
        private System.Windows.Forms.Label emptyTruckCapOutput;
        private System.Windows.Forms.Label lessOrderedLbl;
        private System.Windows.Forms.Label lessOrderedOutput;
        private System.Windows.Forms.Label truckCapRemainLbl;
        private System.Windows.Forms.Label truckCapRemainOutput;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label katieCo;
    }
}

