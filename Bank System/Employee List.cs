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
    public partial class Employee_List : UserControl
    {
        public Employee_List()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            Program.retrieveData(dataGridView2, "select ID ,e.Name,bk.Name , b.Number,b.Address from Employee e left join Branch b on e.Branch_Number = b.Number left join Bank bk on bk.code = b.Bank_Code", 5);
        }
    }
}
