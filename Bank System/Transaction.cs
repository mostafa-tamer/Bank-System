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
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select* from Account where Number=" + textBox6.Text) && Program.retrieveData("select* from Account where Number=" + textBox4.Text))
            {
                if (Program.retrieveData("select balance from Account where Number=" + textBox6.Text + " and Balance>=" + textBox3.Text))
                {
                    Program.insertData(" update Account set Balance= Balance-" + textBox3.Text + " where Account.Number =" + textBox6.Text);
                    Program.insertData(" update Account set Balance= Balance+" + textBox3.Text + " where Account.Number =" + textBox4.Text);

                    MessageBox.Show("Transaction Succeeded!", "BankSystem",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Enough Money!", "BankSystem",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Source Or Dest Acc!", "BankSystem",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
