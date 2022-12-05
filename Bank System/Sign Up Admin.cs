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
    public partial class Sign_Up_Admin : UserControl
    {
        public Sign_Up_Admin()
        {
            InitializeComponent();
        }

        private void Sign_Up_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            Program.insertData("INSERT INTO Admin(Name,Password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "'); ");
            MessageBox.Show("Admin Added Successfully!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
