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
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }
          
        public void button6_Click(object sender, EventArgs e)
        {
            displayUserControls(pay_Loan1);
            Program.obj.employee.pay_Loan1.dataGridView2.Rows.Clear();
            Program.retrieveData(Program.obj.employee.pay_Loan1.dataGridView2, "select l.Number, l.Type ,l.Amount,c.SSN,c.Name from Loan l join Customer c on c.SSN=l.CustomerSSN where _status is null", 5);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayUserControls(add_Customer1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayUserControls(sign_Up_Customer1);
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            displayUserControls(create_Account1);
        }

        private void displayUserControls(UserControl userControl)
        {
            default1.Visible = false;
            add_Customer1.Visible = false;
            sign_Up_Customer1.Visible = false;
            create_Account1.Visible = false;
            updata_Details1.Visible = false;
            pay_Loan1.Visible = false;
            transactionEmployee1.Visible = false;
            withdraw_Deposit1.Visible = false;
            employee_Customer_List1.Visible = false;

            userControl.Visible = true; 
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            displayUserControls(default1);

            default1.label1.Text = "Welcome Employee";

            default1.label1.Left = (default1.Width - default1.label1.Width) / 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayUserControls(updata_Details1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.obj.employee.Visible = false;
            Program.obj.login1.Visible = true;
            Program.obj.login1.username_tb.Text = "";
            Program.obj.login1.password_tb.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayUserControls(transactionEmployee1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayUserControls(withdraw_Deposit1);
        }

        private void default1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayUserControls(employee_Customer_List1);

            Program.obj.employee.employee_Customer_List1.dataGridView1.Rows.Clear();

            Program.obj.employee.employee_Customer_List1.dataGridView2.Rows.Clear();

            Program.retrieveData(Program.obj.employee.employee_Customer_List1.dataGridView1, "select Branch_Number from Employee where ID =" + Program.EmployeeId, 1);

            Program.retrieveData(Program.obj.employee.employee_Customer_List1.dataGridView2, "select c.SSN, c.ID ,c.Name,c.Phone,c.Address,b.Number 'Branch Number', b.Address, k.Name from customer c left join Branch b on b.Number=c.branch_no left join Bank k on k.code=b.Bank_Code where c.branch_no in ( select Number from Branch where Bank_Code in ( select code from Bank b join Branch r on r.Bank_Code=b.code where r.Number=" + Program.obj.employee.employee_Customer_List1.dataGridView1.Rows[0].Cells[0].Value + " ) )", 6);

        }
    }
}
