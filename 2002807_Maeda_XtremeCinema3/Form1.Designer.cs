namespace _2002807_Maeda_XtremeCinema3
{
    partial class Form1
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
            this.exit = new System.Windows.Forms.Button();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.labelNumberM = new System.Windows.Forms.Label();
            this.labelMoviesRented = new System.Windows.Forms.Label();
            this.rentedInput = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.boxCharge = new System.Windows.Forms.GroupBox();
            this.labelRentalAmount = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelAmountDue = new System.Windows.Forms.Label();
            this.rentalAmountT = new System.Windows.Forms.TextBox();
            this.discountT = new System.Windows.Forms.TextBox();
            this.amountDueT = new System.Windows.Forms.TextBox();
            this.boxIncome = new System.Windows.Forms.GroupBox();
            this.totalIncomeT = new System.Windows.Forms.TextBox();
            this.numberServedT = new System.Windows.Forms.TextBox();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labelServed = new System.Windows.Forms.Label();
            this.boxCharge.SuspendLayout();
            this.boxIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(103, 19);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 20);
            this.numberInput.TabIndex = 1;
            // 
            // labelNumberM
            // 
            this.labelNumberM.AutoSize = true;
            this.labelNumberM.Location = new System.Drawing.Point(12, 22);
            this.labelNumberM.Name = "labelNumberM";
            this.labelNumberM.Size = new System.Drawing.Size(85, 13);
            this.labelNumberM.TabIndex = 2;
            this.labelNumberM.Text = "Member Number";
            // 
            // labelMoviesRented
            // 
            this.labelMoviesRented.AutoSize = true;
            this.labelMoviesRented.Location = new System.Drawing.Point(15, 54);
            this.labelMoviesRented.Name = "labelMoviesRented";
            this.labelMoviesRented.Size = new System.Drawing.Size(79, 13);
            this.labelMoviesRented.TabIndex = 3;
            this.labelMoviesRented.Text = "Movies Rented";
            // 
            // rentedInput
            // 
            this.rentedInput.Location = new System.Drawing.Point(103, 51);
            this.rentedInput.Name = "rentedInput";
            this.rentedInput.Size = new System.Drawing.Size(100, 20);
            this.rentedInput.TabIndex = 4;
            // 
            // calculate
            // 
            this.calculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calculate.Location = new System.Drawing.Point(713, 41);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear.Location = new System.Drawing.Point(713, 71);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // boxCharge
            // 
            this.boxCharge.Controls.Add(this.amountDueT);
            this.boxCharge.Controls.Add(this.discountT);
            this.boxCharge.Controls.Add(this.rentalAmountT);
            this.boxCharge.Controls.Add(this.labelAmountDue);
            this.boxCharge.Controls.Add(this.labelDiscount);
            this.boxCharge.Controls.Add(this.labelRentalAmount);
            this.boxCharge.Location = new System.Drawing.Point(209, 12);
            this.boxCharge.Name = "boxCharge";
            this.boxCharge.Size = new System.Drawing.Size(210, 165);
            this.boxCharge.TabIndex = 7;
            this.boxCharge.TabStop = false;
            this.boxCharge.Text = "Charge";
            // 
            // labelRentalAmount
            // 
            this.labelRentalAmount.AutoSize = true;
            this.labelRentalAmount.Location = new System.Drawing.Point(6, 16);
            this.labelRentalAmount.Name = "labelRentalAmount";
            this.labelRentalAmount.Size = new System.Drawing.Size(77, 13);
            this.labelRentalAmount.TabIndex = 0;
            this.labelRentalAmount.Text = "Rental Amount";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(5, 77);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(49, 13);
            this.labelDiscount.TabIndex = 1;
            this.labelDiscount.Text = "Discount";
            // 
            // labelAmountDue
            // 
            this.labelAmountDue.AutoSize = true;
            this.labelAmountDue.Location = new System.Drawing.Point(6, 138);
            this.labelAmountDue.Name = "labelAmountDue";
            this.labelAmountDue.Size = new System.Drawing.Size(66, 13);
            this.labelAmountDue.TabIndex = 2;
            this.labelAmountDue.Text = "Amount Due";
            // 
            // rentalAmountT
            // 
            this.rentalAmountT.Location = new System.Drawing.Point(89, 13);
            this.rentalAmountT.Name = "rentalAmountT";
            this.rentalAmountT.Size = new System.Drawing.Size(100, 20);
            this.rentalAmountT.TabIndex = 3;
            // 
            // discountT
            // 
            this.discountT.Location = new System.Drawing.Point(89, 74);
            this.discountT.Name = "discountT";
            this.discountT.Size = new System.Drawing.Size(100, 20);
            this.discountT.TabIndex = 4;
            // 
            // amountDueT
            // 
            this.amountDueT.Location = new System.Drawing.Point(89, 135);
            this.amountDueT.Name = "amountDueT";
            this.amountDueT.Size = new System.Drawing.Size(100, 20);
            this.amountDueT.TabIndex = 5;
            // 
            // boxIncome
            // 
            this.boxIncome.Controls.Add(this.totalIncomeT);
            this.boxIncome.Controls.Add(this.numberServedT);
            this.boxIncome.Controls.Add(this.labelTotalIncome);
            this.boxIncome.Controls.Add(this.labelServed);
            this.boxIncome.Location = new System.Drawing.Point(425, 12);
            this.boxIncome.Name = "boxIncome";
            this.boxIncome.Size = new System.Drawing.Size(210, 107);
            this.boxIncome.TabIndex = 8;
            this.boxIncome.TabStop = false;
            this.boxIncome.Text = "Income";
            // 
            // totalIncomeT
            // 
            this.totalIncomeT.Location = new System.Drawing.Point(104, 74);
            this.totalIncomeT.Name = "totalIncomeT";
            this.totalIncomeT.Size = new System.Drawing.Size(100, 20);
            this.totalIncomeT.TabIndex = 4;
            // 
            // numberServedT
            // 
            this.numberServedT.Location = new System.Drawing.Point(104, 21);
            this.numberServedT.Name = "numberServedT";
            this.numberServedT.Size = new System.Drawing.Size(100, 20);
            this.numberServedT.TabIndex = 3;
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Location = new System.Drawing.Point(5, 77);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(69, 13);
            this.labelTotalIncome.TabIndex = 1;
            this.labelTotalIncome.Text = "Total Income";
            // 
            // labelServed
            // 
            this.labelServed.AutoSize = true;
            this.labelServed.Location = new System.Drawing.Point(6, 24);
            this.labelServed.Name = "labelServed";
            this.labelServed.Size = new System.Drawing.Size(93, 13);
            this.labelServed.TabIndex = 0;
            this.labelServed.Text = "Customers Served";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxIncome);
            this.Controls.Add(this.boxCharge);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.rentedInput);
            this.Controls.Add(this.labelMoviesRented);
            this.Controls.Add(this.labelNumberM);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Xtreme Cinema Unit 3";
            this.boxCharge.ResumeLayout(false);
            this.boxCharge.PerformLayout();
            this.boxIncome.ResumeLayout(false);
            this.boxIncome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label labelNumberM;
        private System.Windows.Forms.Label labelMoviesRented;
        private System.Windows.Forms.TextBox rentedInput;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox boxCharge;
        private System.Windows.Forms.TextBox amountDueT;
        private System.Windows.Forms.TextBox discountT;
        private System.Windows.Forms.TextBox rentalAmountT;
        private System.Windows.Forms.Label labelAmountDue;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelRentalAmount;
        private System.Windows.Forms.GroupBox boxIncome;
        private System.Windows.Forms.TextBox totalIncomeT;
        private System.Windows.Forms.TextBox numberServedT;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label labelServed;
    }
}

