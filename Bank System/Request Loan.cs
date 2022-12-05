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
    public partial class Request_Loan : UserControl
    {
        public Request_Loan()
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
            Program.retrieveData(dataGridView1, "select ssn from customer where id =" + Program.CustomerID, 1);

            Program.insertData("insert into Loan(Amount,Type,CustomerSSN) values(" + textBox4.Text + ",'" + comboBox1.SelectedItem + "'," + dataGridView1.Rows[0].Cells[0].Value + ")");

            MessageBox.Show("Loan Requested Succesfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
