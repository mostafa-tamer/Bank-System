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
    public partial class Add_Customer : UserControl
    {
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select* from customer where ssn=" + textBox5.Text) == false)
            {
                Program.insertData("insert into Customer values('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "',null,((select Branch_Number from Employee where ID = " + Program.EmployeeId + ")));");
                MessageBox.Show("Customer Added Successfully!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This Customer SSN Already Exist!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
