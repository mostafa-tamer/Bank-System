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
    public partial class Employees_Stats : UserControl
    {
        public Employees_Stats()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            if (Program.retrieveData("select* from employee") == false)
            {
                MessageBox.Show("No Employees In The System!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView1.Rows.Clear();
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";

            Program.retrieveData(dataGridView1, "SELECT top 1 e.ID,e.Name ,count(l.Number) loan_num from Employee e join Loan l on l.Emp_ID = e.ID group by e.ID,e.Name order by loan_num desc", 3);
           
            textBox1.Text += dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBox2.Text += dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox3.Text += dataGridView1.Rows[0].Cells[2].Value.ToString();

        }
    }
}
