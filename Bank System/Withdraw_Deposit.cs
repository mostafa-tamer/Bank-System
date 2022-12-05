using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Withdraw_Deposit : UserControl
    {
        public Withdraw_Deposit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select* from account where Number =" + textBox1.Text))
            {
                if (comboBox1.SelectedItem == "Withdraw")
                {
                    if (Program.retrieveData("select* from account where Number =" + textBox1.Text + " and balance >= " + textBox3.Text))
                    {
                        Program.insertData("update Account set Balance= Balance-" + textBox3.Text + " where Account.Number =" + textBox1.Text);

                        MessageBox.Show("Operation Done Successfully!", "BankSystem",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Enough Money In Account Balance!", "BankSystem",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (comboBox1.SelectedItem == "Deposit")
                {
                    Program.insertData("update Account set Balance= Balance+" + textBox3.Text + " where Account.Number =" + textBox1.Text);

                    MessageBox.Show("Operation Done Successfully!", "BankSystem",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Account Number Not Found!", "BankSystem",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
