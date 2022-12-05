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
    public partial class Updata_Details : UserControl
    {
        public Updata_Details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select * from Customer where ssn="+textBox1.Text))
            {
                Program.retrieveData("update Customer set address='"+textBox3.Text+ "',phone='" + textBox2.Text + "' where SSN='" + textBox1.Text + "';");
                MessageBox.Show("Customer Details Updated Succesfully!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Can Not Find A Customer SSN!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
