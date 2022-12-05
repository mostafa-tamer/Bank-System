namespace Bank_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Stop();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}