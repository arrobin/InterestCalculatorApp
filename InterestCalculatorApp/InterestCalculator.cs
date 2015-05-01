using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatorApp
{
    public partial class InterestCalculator : Form
    {
        public InterestCalculator()
        {
            InitializeComponent();
        }

        private void calculateInterestButton_Click(object sender, EventArgs e)
        {
            string bankName = bankNameComboBox.Text;
            double time = Convert.ToDouble(timeTextBox.Text);
            double balance = Convert.ToDouble(balanceTextBox.Text);
            double interest = 0;
            if (bankName == "BRAC")
            {
                interest = (balance*(1 + (0.06*time))-balance);
            }
            if (bankName == "DBBL")
            {
                interest = (balance * (1 + (0.07 * time)) - balance);
            }
            if (bankName == "HSBC")
            {
                interest = (balance * (1 + (0.08 * time))-balance);
            }

            showInterestTextBox.Text = interest.ToString();

        }

        
    }
}
