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
    public partial class Create_Account : UserControl
    {
        public Create_Account()
        {
            InitializeComponent();
             
        }

        private void Create_Account_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.checkFill(this) == false)
            {
                return;
            }

            if (Program.retrieveData("select* from customer where ssn='" + textBox5.Text + "'"))
            {
                Program.insertData("insert into Account values('" + comboBox2.SelectedItem + "','" + textBox3.Text + "'," + Program.EmployeeId + ",'" + textBox5.Text + "')");

                MessageBox.Show("Account Addded Succesfully!", "BankSystem",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This Customer Is Not Added Yet!", "BankSystem",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
