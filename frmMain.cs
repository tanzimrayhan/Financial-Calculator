using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalculations
{
    public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnInvestment_Click(object sender, EventArgs e)
		{
			frmInvestment form = new frmInvestment();
            this.Hide();
			form.ShowDialog();
            this.Show();
		}

		private void btnDepreciation_Click(object sender, EventArgs e)
		{
			frmDepreciation form = new frmDepreciation();
            this.Hide();
			form.ShowDialog();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About_Me form = new About_Me();
            this.Hide();
            form.ShowDialog();
           this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment_Calculator form = new Payment_Calculator();
            this.Hide();
            form.ShowDialog();
            this.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}