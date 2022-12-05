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
    public partial class Login : UserControl
    { 
        public Login()
        {
            InitializeComponent();

            pictureBox1.Height = username_tb.Height;
            pictureBox2.Height = username_tb.Height;

        }

        private void Login_Load(object sender, EventArgs e)
        { 
            dummy.Select();
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.MaximizeBox = false;

            about.StartPosition = FormStartPosition.CenterParent;

            about.FormBorderStyle = FormBorderStyle.FixedDialog;

            about.ShowDialog();
        }
         
        private void login_btn_Click_2(object sender, EventArgs e)
        {
            if (username_tb.Text == "" || password_tb.Text == "")
            {
                MessageBox.Show("Please Fill All Fields!", "BankSystem",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string _ID = username_tb.Text;
            string password = password_tb.Text;
              
            if (Program.retrieveData("select* from admin WHERE password COLLATE Latin1_General_CS_AS = '" + password + "' and id = " + _ID))
            {
                Program.obj.employee.Visible = false;
                Program.obj.admin1.Visible = true;
                Program.obj.customer1.Visible = false;
                this.Visible = false;
                Program.AdminId = _ID;
            }
            else if (Program.retrieveData("select* from employee WHERE password COLLATE Latin1_General_CS_AS = '" + password + "' and id = " + _ID))
            {
                Program.obj.employee.Visible = true;
                Program.obj.admin1.Visible = false;
                Program.obj.customer1.Visible = false;
                this.Visible = false;

                Program.EmployeeId = _ID;
            }
            else if (Program.retrieveData("select* from Customer WHERE password COLLATE Latin1_General_CS_AS = '" + password + "' and id = " + _ID))
            {
                Program.obj.employee.Visible = false;
                Program.obj.admin1.Visible = false;
                Program.obj.customer1.Visible = true;
                this.Visible = false;

                Program.CustomerID = _ID;
            }
            else
            {
                MessageBox.Show("Incorrect ID or password!", "BankSystem", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }
    }
}
