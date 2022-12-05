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
    public partial class Pay_Loan : UserControl
    {
        public Pay_Loan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pay_Loan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Program.checkFill(this) == false)
            {
                return;
            }


            if (Program.retrieveData("select* from loan where _status is null and Number=" + textBox5.Text))
            {
                Program.insertData("update Loan set _status = 1 ,Emp_ID=" + Program.EmployeeId + " where Number=" + textBox5.Text);
                MessageBox.Show("Loan Is Accepted Succesfully!", "BankSystem",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Loan Number!", "BankSystem",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView2.Rows.Clear();
            Program.obj.employee.button6_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Please Fill The Blank Field!", "BankSystem",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (Program.retrieveData("select* from loan where _status is null and Number=" + textBox5.Text))
            {
                Program.insertData("update Loan set _status = 0 ,Emp_ID=" + Program.EmployeeId + " where Number=" + textBox5.Text);
                MessageBox.Show("Loan Is Rejected Succesfully!", "BankSystem",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Loan Number!", "BankSystem",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView2.Rows.Clear();
            Program.obj.employee.button6_Click(sender, e);
        }
    }
}
