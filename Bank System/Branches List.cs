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
    public partial class Branches_List : UserControl
    {
        public Branches_List()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            Program.retrieveData(dataGridView2, "select b.Bank_Code ,k.Name, b.Number,b.Address,b.Admin_ID,a.Name from Branch b left join Admin a on a.ID = b.Admin_ID left join Bank k on k.code = b.Bank_Code", 6);
        }
    }
}
