using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        decimal loan_amount = 0.00m;
        int number_of_months = 0;
        decimal interest_rate = 0.00m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(txt_loanAmout.Text, out loan_amount))
            {
                if(int.TryParse(txt_numberOfMonths.Text, out number_of_months))
                {
                    if(decimal.TryParse(txt_interestRate.Text, out interest_rate))
                    {
                        // Sucess

                        // Calculate loan
                        int counter = 0;
                        while(counter < number_of_months)
                        {
                            loan_amount = loan_amount + loan_amount * interest_rate;
                            listBox1.Items.Add("At month " + counter + " the loan is " + loan_amount);

                            counter = counter + 1;
                        }

                        // Done with the while loop
                        txt_finalValue.Text = loan_amount.ToString("c");
                    }
                }
            }   
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_finalValue.Clear();
            listBox1.Items.Clear();
            txt_loanAmout.Clear();
            txt_numberOfMonths.Clear();
            txt_interestRate.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
