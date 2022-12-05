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
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
            
            disableAllMenues();
             
        }

        public void disableAllControles()
        {
            add_Bank1.Visible = false;
            add_Branch1.Hide();
            sign_Up_Admin1.Hide();
            updata_Admin_Details1.Hide();
            sign_Up_Employee1.Hide();
            update_Employee_Details1.Hide();
            customers_List1.Hide();
            employee_List1.Hide();
            loans_List1.Hide();
            banks_List1.Hide();
            branches_List1.Hide();
            branches_Stats1.Hide();
            customer_Stats1.Hide();
            employees_Stats1.Hide();

            default1.Visible = true;
        }

        public void disableAllMenues()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            displayMenue(panel2);
        }

        private void displayMenue(Panel panel)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

            panel.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayMenue(panel3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayMenue(panel4);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            displayMenue(panel5);
        }

        private void button14_Click(object sender, EventArgs e)
        {
             
            Program.obj.admin1.Visible = false;
            Program.obj.login1.Visible = true;

            Program.obj.admin1.disableAllMenues();
            Program.obj.admin1.disableAllControles();

            Program.obj.login1.username_tb.Text = "";
            Program.obj.login1.password_tb.Text = "";
        }
          
        private void button2_Click(object sender, EventArgs e)
        { 
            displayUserControles(add_Bank1);
        }
         
        private void displayUserControles(UserControl userControl)
        {
            add_Bank1.Hide();
            add_Branch1.Hide();
            default1.Hide();
            sign_Up_Employee1.Hide();
            update_Employee_Details1.Hide();
            customers_List1.Hide();
            sign_Up_Admin1.Hide();
            updata_Admin_Details1.Hide();
            banks_List1.Hide();
            branches_List1.Hide();
            loans_List1.Hide();
            admin_List1.Hide();    
            employee_List1.Hide();
            branches_Stats1.Hide();
            customer_Stats1.Hide();
            employees_Stats1.Hide();


            userControl.Visible = true;  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayUserControles(add_Branch1);
            Program.retrieveData(Program.obj.admin1.add_Branch1.dataGridView2, "Select code,name,address from bank", 3);
        } 

        private void button5_Click(object sender, EventArgs e)
        {
            displayUserControles(sign_Up_Admin1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayUserControles(updata_Admin_Details1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayUserControles(customers_List1);
            Program.obj.admin1.customers_List1.dataGridView2.Rows.Clear();
            Program.retrieveData(Program.obj.admin1.customers_List1.dataGridView2, "select ID,SSN,Name,Address,Phone from Customer ", 5);
             
        }

        private void button18_Click(object sender, EventArgs e)
        {
            displayUserControles(sign_Up_Employee1);

            Program.retrieveData(Program.obj.admin1.sign_Up_Employee1.dataGridView2, "select b.Name,r.Number ,r.Address from Branch r join Bank b on r.Bank_Code=b.code", 3);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            displayUserControles(update_Employee_Details1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            displayUserControles(banks_List1);
            Program.obj.admin1.banks_List1.dataGridView2.Rows.Clear();
            Program.retrieveData(Program.obj.admin1.banks_List1.dataGridView2, "select b.* ,a.Name from Bank b left join Admin a on a.ID = b.Admin_ID ; ", 5);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            displayUserControles(branches_List1);
            Program.obj.admin1.branches_List1.dataGridView2.Rows.Clear();

            Program.retrieveData(Program.obj.admin1.branches_List1.dataGridView2, "select b.Bank_Code ,k.Name, b.Number,b.Address,b.Admin_ID,a.Name from Branch b left join Admin a on a.ID = b.Admin_ID left join Bank k on k.code = b.Bank_Code", 6);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayUserControles(employee_List1);
            Program.obj.admin1.employee_List1.dataGridView2.Rows.Clear();
            Program.retrieveData(Program.obj.admin1.employee_List1.dataGridView2, "select ID ,e.Name,bk.Name , b.Number,b.Address from Employee e left join Branch b on e.Branch_Number = b.Number left join Bank bk on bk.code = b.Bank_Code", 5);
             
        }

        private void button15_Click(object sender, EventArgs e)
        {
            displayUserControles(loans_List1);
            Program.obj.admin1.loans_List1.dataGridView2.Rows.Clear();

            Program.obj.admin1.loans_List1.dataGridView1.Visible = false;
            Program.obj.admin1.loans_List1.dataGridView2.Visible = true;

            Program.retrieveData(Program.obj.admin1.loans_List1.dataGridView2, "select l.Number,l.Amount,l.Type,l.CustomerSSN, c.Name as 'Customer name',l.Emp_ID,e.Name as 'employee name',l._status " +
                "from Loan l left join Customer c on CustomerSSN = c.SSN" +
                " left join Employee e on Emp_ID = e.ID; ", 8);

            for (int i = 0; i < Program.obj.admin1.loans_List1.dataGridView2.RowCount; i++)
            {
                if (Program.obj.admin1.loans_List1.dataGridView2.Rows[i].Cells[7].Value == null)
                {
                    continue;
                }
                if (Program.obj.admin1.loans_List1.dataGridView2.Rows[i].Cells[7].Value.ToString().Equals("1"))
                {
                    Program.obj.admin1.loans_List1.dataGridView2.Rows[i].Cells[7].Value = "Accepted";
                }
                else if (Program.obj.admin1.loans_List1.dataGridView2.Rows[i].Cells[7].Value.ToString().Equals("0"))
                {
                    Program.obj.admin1.loans_List1.dataGridView2.Rows[i].Cells[7].Value = "Rejected";
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            displayUserControles(branches_Stats1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            displayUserControles(customer_Stats1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            displayUserControles(employees_Stats1);
            employees_Stats1.button1_Click(sender, e); 
        }

        private void button20_Click(object sender, EventArgs e)
        { 
            displayUserControles(admin_List1);
            Program.obj.admin1.admin_List1.dataGridView2.Rows.Clear();

            Program.retrieveData(Program.obj.admin1.admin_List1.dataGridView2, "select * from admin",2);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            default1.label1.Text = "Welcome Admin";

            default1.label1.Left = (default1.Width - default1.label1.Width) / 2;

        }

        private void default1_Load(object sender, EventArgs e)
        {

        }
    }
} 