namespace Bank_System
{
    partial class Customer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.left_menu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.default1 = new Bank_System.Default();
            this.request_Loan1 = new Bank_System.Request_Loan();
            this.transaction1 = new Bank_System.Transaction();
            this.view_Acc_Details1 = new Bank_System.View_Acc_Details();
            this.view_Requested_Loans1 = new Bank_System.View_Requested_Loans();
            this.left_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left_menu
            // 
            this.left_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.left_menu.Controls.Add(this.button5);
            this.left_menu.Controls.Add(this.button4);
            this.left_menu.Controls.Add(this.label2);
            this.left_menu.Controls.Add(this.pictureBox1);
            this.left_menu.Controls.Add(this.button1);
            this.left_menu.Controls.Add(this.button3);
            this.left_menu.Controls.Add(this.button2);
            this.left_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_menu.Location = new System.Drawing.Point(0, 0);
            this.left_menu.Name = "left_menu";
            this.left_menu.Padding = new System.Windows.Forms.Padding(10);
            this.left_menu.Size = new System.Drawing.Size(235, 720);
            this.left_menu.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(10, 467);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 42);
            this.button5.TabIndex = 20;
            this.button5.Text = "View Requested Loans";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(10, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 42);
            this.button4.TabIndex = 19;
            this.button4.Text = "Transaction";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(10, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 2);
            this.label2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(45, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Sign Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(10, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "View Account Details";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(10, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Request Loan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // default1
            // 
            this.default1.BackColor = System.Drawing.Color.White;
            this.default1.Location = new System.Drawing.Point(235, 0);
            this.default1.Name = "default1";
            this.default1.Size = new System.Drawing.Size(845, 720);
            this.default1.TabIndex = 18;
            this.default1.Load += new System.EventHandler(this.default1_Load);
            // 
            // request_Loan1
            // 
            this.request_Loan1.BackColor = System.Drawing.Color.White;
            this.request_Loan1.Location = new System.Drawing.Point(235, 0);
            this.request_Loan1.Name = "request_Loan1";
            this.request_Loan1.Size = new System.Drawing.Size(845, 720);
            this.request_Loan1.TabIndex = 19;
            // 
            // transaction1
            // 
            this.transaction1.BackColor = System.Drawing.Color.White;
            this.transaction1.Location = new System.Drawing.Point(235, 0);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(845, 720);
            this.transaction1.TabIndex = 20;
            // 
            // view_Acc_Details1
            // 
            this.view_Acc_Details1.BackColor = System.Drawing.Color.White;
            this.view_Acc_Details1.Location = new System.Drawing.Point(235, 0);
            this.view_Acc_Details1.Name = "view_Acc_Details1";
            this.view_Acc_Details1.Size = new System.Drawing.Size(845, 720);
            this.view_Acc_Details1.TabIndex = 20;
            // 
            // view_Requested_Loans1
            // 
            this.view_Requested_Loans1.BackColor = System.Drawing.Color.White;
            this.view_Requested_Loans1.Location = new System.Drawing.Point(235, -3);
            this.view_Requested_Loans1.Name = "view_Requested_Loans1";
            this.view_Requested_Loans1.Size = new System.Drawing.Size(845, 720);
            this.view_Requested_Loans1.TabIndex = 21;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.default1);
            this.Controls.Add(this.left_menu);
            this.Controls.Add(this.request_Loan1);
            this.Controls.Add(this.transaction1);
            this.Controls.Add(this.view_Acc_Details1);
            this.Controls.Add(this.view_Requested_Loans1);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(1080, 720);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.left_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel left_menu;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button4;
        private Request_Loan request_Loan1;
        private Transaction transaction1;
        private View_Acc_Details view_Acc_Details1;
        public Default default1;
        private Button button5;
        private View_Requested_Loans view_Requested_Loans1;
    }
}
