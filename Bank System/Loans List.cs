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
    public partial class Loans_List : UserControl
    {
        public Loans_List()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView1.Rows.Clear();
            if (checkBox1.Checked)
            {
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
                Program.retrieveData(dataGridView1, "select distinct Type from Loan;", 1);
            }
            else
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;

                Program.retrieveData(dataGridView2, "select l.Number,l.Amount,l.Type,l.CustomerSSN, c.Name as 'Customer name',l.Emp_ID,e.Name as 'employee name',l._status " +
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
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Loans_List_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
