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
    public partial class Sign_Up_Customer : UserControl
    {
        public Sign_Up_Customer()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            dataGridView1.Rows.Clear();

            if (Program.retrieveData("select* from customer where ssn='" + textBox5.Text + "'"))
            {
                if (Program.retrieveData("select * from customer where ssn ='" + textBox5.Text + "' and Password is null"))
                {
                    Program.insertData("update customer set password = " + textBox1.Text + "where ssn = " + textBox5.Text);

                    Program.retrieveData(dataGridView1, "select id from customer where ssn = " + textBox5.Text, 1);

                    MessageBox.Show("Customer Signed Up Successfully!, Customer ID Is " + dataGridView1.Rows[0].Cells[0].Value, "BankSystem",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("This Customer Has Already Signed Up!", "BankSystem",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Customer Is Not Added Yet!", "BankSystem",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

 