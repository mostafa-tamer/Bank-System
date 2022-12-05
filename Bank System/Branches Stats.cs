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
    public partial class Branches_Stats : UserControl
    {
        public Branches_Stats()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                this.dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
                Program.retrieveData(dataGridView2, "select Branch.Bank_Code,b.Name, Branch.Number,Branch.Address from Branch join Bank b on b.code= Branch.Bank_Code where Number not in( select b.Number from Customer c join Branch b on c.branch_no = b.Number)", 4);
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear(); 
                Program.retrieveData(dataGridView2, "select Bank.code,Bank.Name,Branch.Number,Branch.Address from Branch,Bank where Branch.Number not in( select b.Number from Employee e join Branch b on e.Branch_Number = b.Number) and Bank.code = Branch.Bank_Code", 4);
            }
        }
    }
}
