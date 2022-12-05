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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();

            default1.label1.Text = "Welcome Customer";

            default1.label1.Left = (default1.Width - default1.label1.Width) / 2;
        }
          
        private void displayUserControls(UserControl userControl)
        {
            default1.Visible = false;
            request_Loan1.Visible = false;
            transaction1.Visible = false;
            view_Acc_Details1.Visible = false;
            view_Requested_Loans1.Visible = false;

            userControl.Visible = true; 
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            displayUserControls(default1);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Program.obj.employee.Visible = false;
            Program.obj.admin1.Visible = false;
            Program.obj.customer1.Visible = false;
            Program.obj.login1.Visible = true;
             
            Program.obj.login1.username_tb.Text = "";
            Program.obj.login1.password_tb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayUserControls(request_Loan1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayUserControls(transaction1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayUserControls(view_Acc_Details1);

            Program.obj.customer1.view_Acc_Details1.dataGridView2.Rows.Clear();

            Program.retrieveData(Program.obj.customer1.view_Acc_Details1.dataGridView2, "select Number,balance, type from account,customer where CustomerSSN=SSN and ID ="+Program.CustomerID, 3);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayUserControls(view_Requested_Loans1);

            Program.retrieveData(Program.obj.customer1.view_Requested_Loans1.dataGridView2, "select number, amount, type,_status from loan join Customer on Customer.SSN= CustomerSSN where customer.ID= " + Program.CustomerID, 4);

            for (int i = 0;i< Program.obj.customer1.view_Requested_Loans1.dataGridView2.RowCount; i++)
            {
                if (Program.obj.customer1.view_Requested_Loans1.dataGridView2.Rows[i].Cells[3].Value == null)
                { 
                    continue;
                }
                if (Program.obj.customer1.view_Requested_Loans1.dataGridView2.Rows[i].Cells[3].Value.ToString().Equals("1"))
                {
                    Program.obj.customer1.view_Requested_Loans1.dataGridView2.Rows[i].Cells[3].Value = "Accepted";
                }
                else if (Program.obj.customer1.view_Requested_Loans1.dataGridView2.Rows[i].Cells[3].Value.ToString().Equals("0"))
                {
                    Program.obj.customer1.view_Requested_Loans1.dataGridView2.Rows[i].Cells[3].Value = "Rejected";
                }
            } 
        }

        private void default1_Load(object sender, EventArgs e)
        {

        }
    }
}
