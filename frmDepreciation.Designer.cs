namespace FinancialCalculations
{
	partial class frmDepreciation
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDepreciation = new System.Windows.Forms.ListBox();
            this.cboLife = new System.Windows.Forms.ComboBox();
            this.txtFinalValue = new System.Windows.Forms.TextBox();
            this.txtInitialCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(192, 254);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(76, 254);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "SYD Depreciation:";
            // 
            // lstDepreciation
            // 
            this.lstDepreciation.FormattingEnabled = true;
            this.lstDepreciation.ItemHeight = 16;
            this.lstDepreciation.Location = new System.Drawing.Point(16, 143);
            this.lstDepreciation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstDepreciation.Name = "lstDepreciation";
            this.lstDepreciation.Size = new System.Drawing.Size(275, 84);
            this.lstDepreciation.TabIndex = 16;
            this.lstDepreciation.TabStop = false;
            // 
            // cboLife
            // 
            this.cboLife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLife.FormattingEnabled = true;
            this.cboLife.Location = new System.Drawing.Point(176, 82);
            this.cboLife.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLife.Name = "cboLife";
            this.cboLife.Size = new System.Drawing.Size(111, 24);
            this.cboLife.TabIndex = 13;
            // 
            // txtFinalValue
            // 
            this.txtFinalValue.Location = new System.Drawing.Point(176, 49);
            this.txtFinalValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFinalValue.Name = "txtFinalValue";
            this.txtFinalValue.Size = new System.Drawing.Size(111, 22);
            this.txtFinalValue.TabIndex = 10;
            // 
            // txtInitialCost
            // 
            this.txtInitialCost.Location = new System.Drawing.Point(176, 15);
            this.txtInitialCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInitialCost.Name = "txtInitialCost";
            this.txtInitialCost.Size = new System.Drawing.Size(111, 22);
            this.txtInitialCost.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Life of asset in years:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Final value of asset:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Initial cost of asset:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmDepreciation
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(313, 299);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstDepreciation);
            this.Controls.Add(this.cboLife);
            this.Controls.Add(this.txtFinalValue);
            this.Controls.Add(this.txtInitialCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDepreciation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SYD Depreciation";
            this.Load += new System.EventHandler(this.frmDepreciation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lstDepreciation;
		private System.Windows.Forms.ComboBox cboLife;
		private System.Windows.Forms.TextBox txtFinalValue;
		private System.Windows.Forms.TextBox txtInitialCost;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
	}
}