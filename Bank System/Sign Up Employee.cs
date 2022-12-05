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
    public partial class Sign_Up_Employee : UserControl
    {
        public Sign_Up_Employee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void Sign_Up_Employee_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // INSERT INTO Employee(Name, Branch_Number, Password) VALUES('wael', 11224, 'wael123456');
             
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select* from branch where number='"+ textBox3.Text + "'"))
            {
                Program.retrieveData("INSERT INTO Employee(Name, Branch_Number, Password) VALUES('" + textBox6.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "');");

                Program.retrieveData(dataGridView1, "select max(id)from employee", 1);

                MessageBox.Show("Employee Added Successfully!, Employee ID "+dataGridView1.Rows[0].Cells[0].Value, "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Branch Number!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
