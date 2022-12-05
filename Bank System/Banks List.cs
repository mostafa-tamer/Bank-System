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
    public partial class Banks_List : UserControl
    {
        public Banks_List()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            Program.retrieveData(dataGridView2, "select b.* ,a.Name from Bank b left join Admin a on a.ID = b.Admin_ID ; ",5);
        }
    }
}
