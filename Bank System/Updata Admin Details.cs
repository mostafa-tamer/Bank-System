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
    public partial class Updata_Admin_Details : UserControl
    {
        public Updata_Admin_Details()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select* from admin where id='" + textBox1.Text + "'"))
            {
                Program.insertData("update Admin set Password = '" + textBox2.Text + "' where ID = '" + textBox1.Text + "'");
                MessageBox.Show("Admin Updated Successfully!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Admin ID!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (textBox1.Text == "1132")
            {
                MessageBox.Show("Can Not Remove Main Admin!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            } 

            if (Program.retrieveData("select* from admin where id='" + textBox1.Text + "'and password = '"+textBox2.Text+"'"))
            { 
                Program.insertData("delete from admin where ID = '" + textBox1.Text + "'");
                MessageBox.Show("Admin Deleted Successfully!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong Admin ID Or Password!", "BankSystem",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
