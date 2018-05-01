namespace FinancialCalculations
{
    partial class Payment_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtMonthlyPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterestRate1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalNumberOfPayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly Pay";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest Rate (APR)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(23, 157);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(183, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLoanAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoanAmount.Location = new System.Drawing.Point(182, 44);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(195, 22);
            this.txtLoanAmount.TabIndex = 1;
            this.txtLoanAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMonthlyPay
            // 
            this.txtMonthlyPay.Location = new System.Drawing.Point(182, 82);
            this.txtMonthlyPay.Name = "txtMonthlyPay";
            this.txtMonthlyPay.Size = new System.Drawing.Size(195, 22);
            this.txtMonthlyPay.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "%";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "$";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtInterestRate1
            // 
            this.txtInterestRate1.Location = new System.Drawing.Point(182, 121);
            this.txtInterestRate1.Name = "txtInterestRate1";
            this.txtInterestRate1.Size = new System.Drawing.Size(195, 22);
            this.txtInterestRate1.TabIndex = 3;
            this.txtInterestRate1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.txtInterestRate1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMonthlyPay);
            this.groupBox1.Controls.Add(this.txtLoanAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 202);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fix Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Number Of Payments";
            // 
            // txtTotalNumberOfPayment
            // 
            this.txtTotalNumberOfPayment.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalNumberOfPayment.Location = new System.Drawing.Point(200, 319);
            this.txtTotalNumberOfPayment.Name = "txtTotalNumberOfPayment";
            this.txtTotalNumberOfPayment.ReadOnly = true;
            this.txtTotalNumberOfPayment.Size = new System.Drawing.Size(195, 22);
            this.txtTotalNumberOfPayment.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Payment";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalPayment.Location = new System.Drawing.Point(200, 245);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.ReadOnly = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(194, 22);
            this.txtTotalPayment.TabIndex = 18;
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTotalInterest.Location = new System.Drawing.Point(200, 282);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.ReadOnly = true;
            this.txtTotalInterest.Size = new System.Drawing.Size(195, 22);
            this.txtTotalInterest.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Total Interest";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(212, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Payment_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 366);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalInterest);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTotalNumberOfPayment);
            this.Controls.Add(this.label5);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Payment_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Calculator";
            this.Load += new System.EventHandler(this.Payment_Calculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtMonthlyPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterestRate1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalNumberOfPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExit;
    }
}