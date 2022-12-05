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
    public partial class Add_Bank : UserControl
    {
        public Add_Bank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            Program.insertData("INSERT INTO Bank VALUES('"+textBox1.Text+ "', '" + textBox2.Text + "','" + Program.AdminId + "');");
            MessageBox.Show("Bank Added Successfully!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
