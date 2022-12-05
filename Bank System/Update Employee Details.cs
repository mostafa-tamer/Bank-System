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
    public partial class Update_Employee_Details : UserControl
    {
        public Update_Employee_Details()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select* from employee where id='" + textBox1.Text + "'"))
            {
                Program.insertData("update Employee set Password = '" + textBox2.Text + "' where ID = '" + textBox1.Text + "'");
                MessageBox.Show("Employee Updated Successfully!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Employee ID!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select* from employee where id='" + textBox1.Text + "'and password = '" + textBox2.Text + "'"))
            {
                Program.insertData("delete from employee where ID = '" + textBox1.Text + "'");
                MessageBox.Show("Employee Deleted Successfully!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Employee ID Or Password!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
