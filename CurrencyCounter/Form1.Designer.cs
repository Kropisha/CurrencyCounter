namespace CurrencyCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbResultCurrency = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSecondMain = new System.Windows.Forms.TextBox();
            this.cbSecond = new System.Windows.Forms.ComboBox();
            this.tbSecondCoins = new System.Windows.Forms.TextBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstMain = new System.Windows.Forms.TextBox();
            this.cbFirst = new System.Windows.Forms.ComboBox();
            this.tbFirstCoins = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbResultCurrency);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.cbOperation);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 380);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Thistle;
            this.lblResult.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(114, 302);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(75, 24);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "Result: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Choose the result currency:";
            // 
            // cbResultCurrency
            // 
            this.cbResultCurrency.BackColor = System.Drawing.Color.Thistle;
            this.cbResultCurrency.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResultCurrency.FormattingEnabled = true;
            this.cbResultCurrency.Location = new System.Drawing.Point(315, 170);
            this.cbResultCurrency.Name = "cbResultCurrency";
            this.cbResultCurrency.Size = new System.Drawing.Size(111, 29);
            this.cbResultCurrency.TabIndex = 16;
            this.cbResultCurrency.Click += new System.EventHandler(this.CbResultCurrency_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbSecondMain);
            this.groupBox2.Controls.Add(this.cbSecond);
            this.groupBox2.Controls.Add(this.tbSecondCoins);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(457, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = ",";
            // 
            // tbSecondMain
            // 
            this.tbSecondMain.Location = new System.Drawing.Point(6, 35);
            this.tbSecondMain.Name = "tbSecondMain";
            this.tbSecondMain.Size = new System.Drawing.Size(70, 28);
            this.tbSecondMain.TabIndex = 2;
            // 
            // cbSecond
            // 
            this.cbSecond.FormattingEnabled = true;
            this.cbSecond.Location = new System.Drawing.Point(197, 34);
            this.cbSecond.Name = "cbSecond";
            this.cbSecond.Size = new System.Drawing.Size(74, 29);
            this.cbSecond.TabIndex = 3;
            // 
            // tbSecondCoins
            // 
            this.tbSecondCoins.Location = new System.Drawing.Point(98, 35);
            this.tbSecondCoins.Name = "tbSecondCoins";
            this.tbSecondCoins.Size = new System.Drawing.Size(70, 28);
            this.tbSecondCoins.TabIndex = 4;
            // 
            // cbOperation
            // 
            this.cbOperation.BackColor = System.Drawing.Color.Thistle;
            this.cbOperation.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbOperation.Location = new System.Drawing.Point(327, 53);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(82, 29);
            this.cbOperation.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbFirstMain);
            this.groupBox1.Controls.Add(this.cbFirst);
            this.groupBox1.Controls.Add(this.tbFirstCoins);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "first";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = ",";
            // 
            // tbFirstMain
            // 
            this.tbFirstMain.Location = new System.Drawing.Point(6, 35);
            this.tbFirstMain.Name = "tbFirstMain";
            this.tbFirstMain.Size = new System.Drawing.Size(70, 28);
            this.tbFirstMain.TabIndex = 2;
            // 
            // cbFirst
            // 
            this.cbFirst.FormattingEnabled = true;
            this.cbFirst.Location = new System.Drawing.Point(197, 34);
            this.cbFirst.Name = "cbFirst";
            this.cbFirst.Size = new System.Drawing.Size(74, 29);
            this.cbFirst.TabIndex = 3;
            // 
            // tbFirstCoins
            // 
            this.tbFirstCoins.Location = new System.Drawing.Point(98, 35);
            this.tbFirstCoins.Name = "tbFirstCoins";
            this.tbFirstCoins.Size = new System.Drawing.Size(70, 28);
            this.tbFirstCoins.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Thistle;
            this.btnCalculate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(315, 229);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(111, 34);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Thistle;
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(657, 324);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 31);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 419);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Currency Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbResultCurrency;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSecondMain;
        private System.Windows.Forms.ComboBox cbSecond;
        private System.Windows.Forms.TextBox tbSecondCoins;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstMain;
        private System.Windows.Forms.ComboBox cbFirst;
        private System.Windows.Forms.TextBox tbFirstCoins;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

