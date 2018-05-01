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
    public partial class Payment_Calculator : Form
    {
        private object txtInterestRate;

        public Payment_Calculator()
        {
            InitializeComponent();
        }

        private void Payment_Calculator_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtLoanAmount;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                /*Getting the yearly interest rate and calculating monthly interest rate from it*/
                decimal yearlyInterestRate =
                        Convert.ToDecimal(txtInterestRate1.Text);
                decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                //Getting the monthly payment
                decimal monthlyPay = Convert.ToDecimal(txtMonthlyPay.Text);
                //Getting the loan amount from user
                decimal loanAmount = Convert.ToDecimal(txtLoanAmount.Text);

                //Calculating Number of payments
                decimal numberOfPayments =
                            Calculations.CalculateNumberOfPayments(
                                monthlyInterestRate,
                                monthlyPay,
                                loanAmount);

                //Calculating total interest
                decimal totalInterest = (monthlyPay * numberOfPayments) - loanAmount;

                //Calculating total amount
                decimal totalAmount = loanAmount + totalInterest;

                if (totalAmount < loanAmount)
                    MessageBox.Show("Invalid input", "Please put valid numbers");


                //Generating Number of Payment
                txtTotalNumberOfPayment.Text =
                             Convert.ToString(numberOfPayments);

                //Generating Total Payment
                txtTotalPayment.Text =
                            String.Format("{0:c}", totalAmount);

                //Generating Total Interest
                txtTotalInterest.Text = String.Format("{0:c}", totalInterest);



            }

            catch (OverflowException)
            {
                MessageBox.Show("You will not be able to pay the loan at this rate, try inputting a larger Monthly Pay.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            catch (FormatException)
            {
                MessageBox.Show("All entries must be numeric.", "Entry Error");
            }
        }

            
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain Form = new frmMain();
            Form.Show();
        }
    }
}
