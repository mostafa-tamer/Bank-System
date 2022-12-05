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
    public partial class Customer_Stats : UserControl
    {
        public Customer_Stats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            dataGridView3.Rows.Clear();

            if (comboBox2.SelectedIndex == 0)
            {
                dataGridView1.Visible = false;
                dataGridView3.Visible = false;
                dataGridView2.Visible = true;
                Program.retrieveData(dataGridView2, "SELECT c.ssn,c.Name ,c.Phone,c.address,count(l.Number) loan_num from Customer c join Loan l on l.CustomerSSN = c.SSN group by c.ssn,c.Name ,c.Phone,c.address having count(l.Number) in ( SELECT top 1 count(l.Number) loan_num from Customer c join Loan l on l.CustomerSSN = c.SSN group by c.ID,c.Name order by loan_num desc)", 5);

            }
            else if (comboBox2.SelectedIndex == 1)
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;

                Program.retrieveData(dataGridView1, "select ssn,name,phone,address from Customer where  SSN not in( select c.SSN from Customer c join Loan l on l.CustomerSSN=c.SSN )", 4);
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
                Program.retrieveData(dataGridView3, "select c.ID,c.SSN,c.Name,c.Address,c.Phone, COUNT( distinct a.Emp_ID) account_emp, COUNT( distinct l.Emp_ID) loan_emp, COUNT(distinct e.ID ) total_emp from Customer c left join Account a on a.CustomerSSN=c.SSN left join Loan l on l.CustomerSSN=c.SSN left join Employee e on a.Emp_ID = e.ID or l.Emp_ID = e.ID group by c.ID,c.SSN,c.Name,c.Address,c.Phone", 8);

            }
        }
    }
}
