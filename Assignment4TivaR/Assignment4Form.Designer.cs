namespace Assignment4TivaR
{
    partial class Assignment4Form
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
            this.lblIntroQ = new System.Windows.Forms.Label();
            this.picPizzaMan = new System.Windows.Forms.PictureBox();
            this.lblSizeQuestion = new System.Windows.Forms.Label();
            this.lblToppingsQuestion = new System.Windows.Forms.Label();
            this.lblSodaQuestion = new System.Windows.Forms.Label();
            this.lblCostOfLarge = new System.Windows.Forms.Label();
            this.lblCostOfSmall = new System.Windows.Forms.Label();
            this.lblCostofXLarge = new System.Windows.Forms.Label();
            this.grbSize = new System.Windows.Forms.GroupBox();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.lblTopping3 = new System.Windows.Forms.Label();
            this.lblTopping1 = new System.Windows.Forms.Label();
            this.lblTopping2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopping4 = new System.Windows.Forms.Label();
            this.nudSizeSelection = new System.Windows.Forms.NumericUpDown();
            this.nudToppingsSelection = new System.Windows.Forms.NumericUpDown();
            this.radSodaYes = new System.Windows.Forms.RadioButton();
            this.grbSoda = new System.Windows.Forms.GroupBox();
            this.radSodaNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaMan)).BeginInit();
            this.grbSize.SuspendLayout();
            this.grbToppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingsSelection)).BeginInit();
            this.grbSoda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntroQ
            // 
            this.lblIntroQ.AutoSize = true;
            this.lblIntroQ.Location = new System.Drawing.Point(142, 41);
            this.lblIntroQ.Name = "lblIntroQ";
            this.lblIntroQ.Size = new System.Drawing.Size(262, 13);
            this.lblIntroQ.TabIndex = 0;
            this.lblIntroQ.Text = "Hello welcome to the Pizza Place. What is your order?";
            // 
            // picPizzaMan
            // 
            this.picPizzaMan.Image = global::Assignment4TivaR.Properties.Resources.Earth;
            this.picPizzaMan.Location = new System.Drawing.Point(437, 81);
            this.picPizzaMan.Name = "picPizzaMan";
            this.picPizzaMan.Size = new System.Drawing.Size(146, 226);
            this.picPizzaMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPizzaMan.TabIndex = 1;
            this.picPizzaMan.TabStop = false;
            // 
            // lblSizeQuestion
            // 
            this.lblSizeQuestion.AutoSize = true;
            this.lblSizeQuestion.Location = new System.Drawing.Point(6, 22);
            this.lblSizeQuestion.Name = "lblSizeQuestion";
            this.lblSizeQuestion.Size = new System.Drawing.Size(160, 13);
            this.lblSizeQuestion.TabIndex = 2;
            this.lblSizeQuestion.Text = "What size of pizza do you want?";
            // 
            // lblToppingsQuestion
            // 
            this.lblToppingsQuestion.AutoSize = true;
            this.lblToppingsQuestion.Location = new System.Drawing.Point(6, 24);
            this.lblToppingsQuestion.Name = "lblToppingsQuestion";
            this.lblToppingsQuestion.Size = new System.Drawing.Size(167, 13);
            this.lblToppingsQuestion.TabIndex = 3;
            this.lblToppingsQuestion.Text = "How many toppings do you want?";
            // 
            // lblSodaQuestion
            // 
            this.lblSodaQuestion.AutoSize = true;
            this.lblSodaQuestion.Location = new System.Drawing.Point(7, 25);
            this.lblSodaQuestion.Name = "lblSodaQuestion";
            this.lblSodaQuestion.Size = new System.Drawing.Size(190, 13);
            this.lblSodaQuestion.TabIndex = 4;
            this.lblSodaQuestion.Text = "Would you like a soda with your pizza?";
            // 
            // lblCostOfLarge
            // 
            this.lblCostOfLarge.AutoSize = true;
            this.lblCostOfLarge.Location = new System.Drawing.Point(7, 78);
            this.lblCostOfLarge.Name = "lblCostOfLarge";
            this.lblCostOfLarge.Size = new System.Drawing.Size(88, 13);
            this.lblCostOfLarge.TabIndex = 5;
            this.lblCostOfLarge.Text = "2 = Large ($9.99)";
            // 
            // lblCostOfSmall
            // 
            this.lblCostOfSmall.AutoSize = true;
            this.lblCostOfSmall.Location = new System.Drawing.Point(7, 53);
            this.lblCostOfSmall.Name = "lblCostOfSmall";
            this.lblCostOfSmall.Size = new System.Drawing.Size(86, 13);
            this.lblCostOfSmall.TabIndex = 6;
            this.lblCostOfSmall.Text = "1 = Small ($7.99)";
            // 
            // lblCostofXLarge
            // 
            this.lblCostofXLarge.AutoSize = true;
            this.lblCostofXLarge.Location = new System.Drawing.Point(6, 102);
            this.lblCostofXLarge.Name = "lblCostofXLarge";
            this.lblCostofXLarge.Size = new System.Drawing.Size(121, 13);
            this.lblCostofXLarge.TabIndex = 7;
            this.lblCostofXLarge.Text = "3 = Extra Large ($12.99)";
            // 
            // grbSize
            // 
            this.grbSize.Controls.Add(this.nudSizeSelection);
            this.grbSize.Controls.Add(this.lblSizeQuestion);
            this.grbSize.Controls.Add(this.lblCostofXLarge);
            this.grbSize.Controls.Add(this.lblCostOfSmall);
            this.grbSize.Controls.Add(this.lblCostOfLarge);
            this.grbSize.Location = new System.Drawing.Point(15, 81);
            this.grbSize.Name = "grbSize";
            this.grbSize.Size = new System.Drawing.Size(280, 127);
            this.grbSize.TabIndex = 8;
            this.grbSize.TabStop = false;
            this.grbSize.Text = "Size";
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.nudToppingsSelection);
            this.grbToppings.Controls.Add(this.lblTopping4);
            this.grbToppings.Controls.Add(this.lblTopping3);
            this.grbToppings.Controls.Add(this.lblTopping1);
            this.grbToppings.Controls.Add(this.lblTopping2);
            this.grbToppings.Controls.Add(this.label1);
            this.grbToppings.Controls.Add(this.lblToppingsQuestion);
            this.grbToppings.Location = new System.Drawing.Point(15, 230);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(280, 144);
            this.grbToppings.TabIndex = 9;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // lblTopping3
            // 
            this.lblTopping3.AutoSize = true;
            this.lblTopping3.Location = new System.Drawing.Point(6, 94);
            this.lblTopping3.Name = "lblTopping3";
            this.lblTopping3.Size = new System.Drawing.Size(96, 13);
            this.lblTopping3.TabIndex = 7;
            this.lblTopping3.Text = "3 Toppings ($2.15)";
            // 
            // lblTopping1
            // 
            this.lblTopping1.AutoSize = true;
            this.lblTopping1.Location = new System.Drawing.Point(6, 51);
            this.lblTopping1.Name = "lblTopping1";
            this.lblTopping1.Size = new System.Drawing.Size(91, 13);
            this.lblTopping1.TabIndex = 6;
            this.lblTopping1.Text = "1 Topping ($0.75)";
            // 
            // lblTopping2
            // 
            this.lblTopping2.AutoSize = true;
            this.lblTopping2.Location = new System.Drawing.Point(6, 73);
            this.lblTopping2.Name = "lblTopping2";
            this.lblTopping2.Size = new System.Drawing.Size(96, 13);
            this.lblTopping2.TabIndex = 5;
            this.lblTopping2.Text = "2 Toppings ($1.35)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lblTopping4
            // 
            this.lblTopping4.AutoSize = true;
            this.lblTopping4.Location = new System.Drawing.Point(6, 116);
            this.lblTopping4.Name = "lblTopping4";
            this.lblTopping4.Size = new System.Drawing.Size(96, 13);
            this.lblTopping4.TabIndex = 8;
            this.lblTopping4.Text = "4 Toppings ($2.75)";
            // 
            // nudSizeSelection
            // 
            this.nudSizeSelection.Location = new System.Drawing.Point(194, 53);
            this.nudSizeSelection.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSizeSelection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSizeSelection.Name = "nudSizeSelection";
            this.nudSizeSelection.Size = new System.Drawing.Size(38, 20);
            this.nudSizeSelection.TabIndex = 8;
            this.nudSizeSelection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudToppingsSelection
            // 
            this.nudToppingsSelection.Location = new System.Drawing.Point(194, 51);
            this.nudToppingsSelection.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudToppingsSelection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToppingsSelection.Name = "nudToppingsSelection";
            this.nudToppingsSelection.Size = new System.Drawing.Size(38, 20);
            this.nudToppingsSelection.TabIndex = 9;
            this.nudToppingsSelection.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radSodaYes
            // 
            this.radSodaYes.AutoSize = true;
            this.radSodaYes.Location = new System.Drawing.Point(12, 56);
            this.radSodaYes.Name = "radSodaYes";
            this.radSodaYes.Size = new System.Drawing.Size(43, 17);
            this.radSodaYes.TabIndex = 10;
            this.radSodaYes.TabStop = true;
            this.radSodaYes.Text = "Yes";
            this.radSodaYes.UseVisualStyleBackColor = true;
            // 
            // grbSoda
            // 
            this.grbSoda.Controls.Add(this.radSodaNo);
            this.grbSoda.Controls.Add(this.lblSodaQuestion);
            this.grbSoda.Controls.Add(this.radSodaYes);
            this.grbSoda.Location = new System.Drawing.Point(15, 391);
            this.grbSoda.Name = "grbSoda";
            this.grbSoda.Size = new System.Drawing.Size(280, 100);
            this.grbSoda.TabIndex = 11;
            this.grbSoda.TabStop = false;
            this.grbSoda.Text = "Soda";
            // 
            // radSodaNo
            // 
            this.radSodaNo.AutoSize = true;
            this.radSodaNo.Location = new System.Drawing.Point(123, 56);
            this.radSodaNo.Name = "radSodaNo";
            this.radSodaNo.Size = new System.Drawing.Size(39, 17);
            this.radSodaNo.TabIndex = 11;
            this.radSodaNo.TabStop = true;
            this.radSodaNo.Text = "No";
            this.radSodaNo.UseVisualStyleBackColor = true;
            // 
            // Assignment4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 625);
            this.Controls.Add(this.grbSoda);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbSize);
            this.Controls.Add(this.picPizzaMan);
            this.Controls.Add(this.lblIntroQ);
            this.Name = "Assignment4Form";
            this.Text = "Assignment #4 By Tiva Rait";
            ((System.ComponentModel.ISupportInitialize)(this.picPizzaMan)).EndInit();
            this.grbSize.ResumeLayout(false);
            this.grbSize.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingsSelection)).EndInit();
            this.grbSoda.ResumeLayout(false);
            this.grbSoda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntroQ;
        private System.Windows.Forms.PictureBox picPizzaMan;
        private System.Windows.Forms.Label lblSizeQuestion;
        private System.Windows.Forms.Label lblToppingsQuestion;
        private System.Windows.Forms.Label lblSodaQuestion;
        private System.Windows.Forms.Label lblCostOfLarge;
        private System.Windows.Forms.Label lblCostOfSmall;
        private System.Windows.Forms.Label lblCostofXLarge;
        private System.Windows.Forms.GroupBox grbSize;
        private System.Windows.Forms.NumericUpDown nudSizeSelection;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.NumericUpDown nudToppingsSelection;
        private System.Windows.Forms.Label lblTopping4;
        private System.Windows.Forms.Label lblTopping3;
        private System.Windows.Forms.Label lblTopping1;
        private System.Windows.Forms.Label lblTopping2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radSodaYes;
        private System.Windows.Forms.GroupBox grbSoda;
        private System.Windows.Forms.RadioButton radSodaNo;
    }
}

