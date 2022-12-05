namespace Bank_System
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.left_menu = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add_Customer1 = new Bank_System.Add_Customer();
            this.sign_Up_Customer1 = new Bank_System.Sign_Up_Customer();
            this.create_Account1 = new Bank_System.Create_Account();
            this.default1 = new Bank_System.Default();
            this.updata_Details1 = new Bank_System.Updata_Details();
            this.pay_Loan1 = new Bank_System.Pay_Loan();
            this.transactionEmployee1 = new Bank_System.TransactionEmployee();
            this.withdraw_Deposit1 = new Bank_System.Withdraw_Deposit();
            this.employee_Customer_List1 = new Bank_System.Employee_Customer_List();
            this.left_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left_menu
            // 
            this.left_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.left_menu.Controls.Add(this.button9);
            this.left_menu.Controls.Add(this.button8);
            this.left_menu.Controls.Add(this.button5);
            this.left_menu.Controls.Add(this.label2);
            this.left_menu.Controls.Add(this.button4);
            this.left_menu.Controls.Add(this.pictureBox1);
            this.left_menu.Controls.Add(this.button1);
            this.left_menu.Controls.Add(this.button6);
            this.left_menu.Controls.Add(this.button7);
            this.left_menu.Controls.Add(this.button3);
            this.left_menu.Controls.Add(this.button2);
            this.left_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_menu.Location = new System.Drawing.Point(0, 0);
            this.left_menu.Name = "left_menu";
            this.left_menu.Padding = new System.Windows.Forms.Padding(10);
            this.left_menu.Size = new System.Drawing.Size(235, 720);
            this.left_menu.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(10, 530);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(215, 42);
            this.button9.TabIndex = 20;
            this.button9.Text = "Customers List";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(10, 480);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(215, 42);
            this.button8.TabIndex = 19;
            this.button8.Text = "Withdraw And Deposit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(10, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 42);
            this.button5.TabIndex = 18;
            this.button5.Text = "Transaction";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(10, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 2);
            this.label2.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(10, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 42);
            this.button4.TabIndex = 12;
            this.button4.Text = "Update Customer Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(139)))), ((int)(((byte)(197)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 37);
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
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(10, 430);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(215, 42);
            this.button6.TabIndex = 11;
            this.button6.Text = "Pay Loan";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(10, 280);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(215, 42);
            this.button7.TabIndex = 9;
            this.button7.Text = "Create Account";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(10, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sign Up Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(10, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add_Customer1
            // 
            this.add_Customer1.BackColor = System.Drawing.Color.White;
            this.add_Customer1.Location = new System.Drawing.Point(235, 0);
            this.add_Customer1.Name = "add_Customer1";
            this.add_Customer1.Size = new System.Drawing.Size(845, 720);
            this.add_Customer1.TabIndex = 1;
            // 
            // sign_Up_Customer1
            // 
            this.sign_Up_Customer1.BackColor = System.Drawing.Color.White;
            this.sign_Up_Customer1.Location = new System.Drawing.Point(235, 0);
            this.sign_Up_Customer1.Name = "sign_Up_Customer1";
            this.sign_Up_Customer1.Size = new System.Drawing.Size(845, 720);
            this.sign_Up_Customer1.TabIndex = 2;
            // 
            // create_Account1
            // 
            this.create_Account1.BackColor = System.Drawing.Color.White;
            this.create_Account1.Location = new System.Drawing.Point(235, 0);
            this.create_Account1.Name = "create_Account1";
            this.create_Account1.Size = new System.Drawing.Size(845, 720);
            this.create_Account1.TabIndex = 3;
            // 
            // default1
            // 
            this.default1.BackColor = System.Drawing.Color.White;
            this.default1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.default1.Location = new System.Drawing.Point(235, 0);
            this.default1.Name = "default1";
            this.default1.Size = new System.Drawing.Size(845, 720);
            this.default1.TabIndex = 4;
            this.default1.Load += new System.EventHandler(this.default1_Load);
            // 
            // updata_Details1
            // 
            this.updata_Details1.BackColor = System.Drawing.Color.White;
            this.updata_Details1.Location = new System.Drawing.Point(235, 0);
            this.updata_Details1.Name = "updata_Details1";
            this.updata_Details1.Size = new System.Drawing.Size(845, 720);
            this.updata_Details1.TabIndex = 5;
            // 
            // pay_Loan1
            // 
            this.pay_Loan1.BackColor = System.Drawing.Color.White;
            this.pay_Loan1.Location = new System.Drawing.Point(235, 0);
            this.pay_Loan1.Name = "pay_Loan1";
            this.pay_Loan1.Size = new System.Drawing.Size(845, 720);
            this.pay_Loan1.TabIndex = 18;
            // 
            // transactionEmployee1
            // 
            this.transactionEmployee1.BackColor = System.Drawing.Color.White;
            this.transactionEmployee1.Location = new System.Drawing.Point(235, 0);
            this.transactionEmployee1.Name = "transactionEmployee1";
            this.transactionEmployee1.Size = new System.Drawing.Size(845, 720);
            this.transactionEmployee1.TabIndex = 19;
            // 
            // withdraw_Deposit1
            // 
            this.withdraw_Deposit1.BackColor = System.Drawing.Color.White;
            this.withdraw_Deposit1.Location = new System.Drawing.Point(235, 0);
            this.withdraw_Deposit1.Name = "withdraw_Deposit1";
            this.withdraw_Deposit1.Size = new System.Drawing.Size(845, 720);
            this.withdraw_Deposit1.TabIndex = 20;
            // 
            // employee_Customer_List1
            // 
            this.employee_Customer_List1.BackColor = System.Drawing.Color.White;
            this.employee_Customer_List1.Location = new System.Drawing.Point(235, 0);
            this.employee_Customer_List1.Name = "employee_Customer_List1";
            this.employee_Customer_List1.Size = new System.Drawing.Size(845, 720);
            this.employee_Customer_List1.TabIndex = 21;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.default1);
            this.Controls.Add(this.create_Account1);
            this.Controls.Add(this.sign_Up_Customer1);
            this.Controls.Add(this.add_Customer1);
            this.Controls.Add(this.left_menu);
            this.Controls.Add(this.pay_Loan1);
            this.Controls.Add(this.updata_Details1);
            this.Controls.Add(this.transactionEmployee1);
            this.Controls.Add(this.withdraw_Deposit1);
            this.Controls.Add(this.employee_Customer_List1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(1080, 720);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.left_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel left_menu;
        private Button button4;
        private Button button7;
        private Button button3;
        private Button button2;
        private Button button6;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Add_Customer add_Customer1;
        private Sign_Up_Customer sign_Up_Customer1;
        private Create_Account create_Account1;
        private Default default1;
        private Updata_Details updata_Details1;
        private Pay_Loan pay_Loan1;
        private Button button5;
        private TransactionEmployee transactionEmployee1;
        private Button button8;
        private Withdraw_Deposit withdraw_Deposit1;
        private Button button9;
        private Employee_Customer_List employee_Customer_List1;
    }
}
