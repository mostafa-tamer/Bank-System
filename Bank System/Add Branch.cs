using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System
{
    public partial class Add_Branch : UserControl
    {
        public Add_Branch()
        {
            InitializeComponent();
        }

        private void Add_Branch_Load(object sender, EventArgs e)
        {
            Program.retrieveData(dataGridView2, "Select code,name,address from bank", 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select* from bank where code='"+textBox1.Text+"'"))
            {
                Program.insertData("INSERT INTO Branch (Address,Bank_Code,Admin_ID) VALUES('" + textBox2.Text +
                "', '" + textBox1.Text + "','" + Program.AdminId + "'); ");

                MessageBox.Show("Branch Added Successfully!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Bank Code!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
