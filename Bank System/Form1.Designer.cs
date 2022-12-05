namespace Bank_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.employee = new Bank_System.Employee();
            this.admin1 = new Bank_System.Admin();
            this.login1 = new Bank_System.Login();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.welcome1 = new Bank_System.Welcome();
            this.customer1 = new Bank_System.Customer();
            this.SuspendLayout();
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.White;
            this.employee.Location = new System.Drawing.Point(0, 0);
            this.employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(1080, 720);
            this.employee.TabIndex = 0;
            // 
            // admin1
            // 
            this.admin1.Location = new System.Drawing.Point(0, 0);
            this.admin1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(1080, 720);
            this.admin1.TabIndex = 2;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.White;
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1080, 720);
            this.login1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // welcome1
            // 
            this.welcome1.BackColor = System.Drawing.Color.White;
            this.welcome1.Location = new System.Drawing.Point(0, 0);
            this.welcome1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(1080, 720);
            this.welcome1.TabIndex = 3;
            // 
            // customer1
            // 
            this.customer1.BackColor = System.Drawing.Color.White;
            this.customer1.Location = new System.Drawing.Point(0, 0);
            this.customer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customer1.Name = "customer1";
            this.customer1.Size = new System.Drawing.Size(1080, 720);
            this.customer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1080, 719);
            this.Controls.Add(this.welcome1);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.admin1);
            this.Controls.Add(this.customer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }
        #endregion
        public Employee employee;
        public Admin admin1;
        public Login login1;
        private System.Windows.Forms.Timer timer1;
        private Welcome welcome1;
        public Customer customer1;
    }
}