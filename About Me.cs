using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FinancialCalculations
{
    public partial class About_Me : Form
    {
        public About_Me()
        {
            InitializeComponent();
        }

        private void About_Me_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("www.facebook.com/tanzim.rayhan");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.github.com/tanzimrayhan"); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain();
            form.Show();
            this.Close();
        }
    }
}
