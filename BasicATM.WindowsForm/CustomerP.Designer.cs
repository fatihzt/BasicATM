namespace BasicATM.WindowsForm
{
    partial class CustomerP
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_lb = new System.Windows.Forms.Label();
            this.customerid_lb = new System.Windows.Forms.Label();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.fastpay_btn = new System.Windows.Forms.Button();
            this.changepin_btn = new System.Windows.Forms.Button();
            this.transaction_btn = new System.Windows.Forms.Button();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.balance_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.date_lb);
            this.panel1.Controls.Add(this.customerid_lb);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 57);
            this.panel1.TabIndex = 1;
            // 
            // date_lb
            // 
            this.date_lb.BackColor = System.Drawing.Color.SeaShell;
            this.date_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.date_lb.Location = new System.Drawing.Point(600, 0);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(199, 57);
            this.date_lb.TabIndex = 14;
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerid_lb
            // 
            this.customerid_lb.AutoSize = true;
            this.customerid_lb.ForeColor = System.Drawing.Color.SeaShell;
            this.customerid_lb.Location = new System.Drawing.Point(47, 24);
            this.customerid_lb.Name = "customerid_lb";
            this.customerid_lb.Size = new System.Drawing.Size(38, 15);
            this.customerid_lb.TabIndex = 0;
            this.customerid_lb.Text = "label1";
            // 
            // deposit_btn
            // 
            this.deposit_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.deposit_btn.Location = new System.Drawing.Point(29, 140);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(154, 34);
            this.deposit_btn.TabIndex = 6;
            this.deposit_btn.Text = "Deposit";
            this.deposit_btn.UseVisualStyleBackColor = true;
            this.deposit_btn.Click += new System.EventHandler(this.deposit_btn_Click);
            // 
            // fastpay_btn
            // 
            this.fastpay_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fastpay_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.fastpay_btn.Location = new System.Drawing.Point(29, 225);
            this.fastpay_btn.Name = "fastpay_btn";
            this.fastpay_btn.Size = new System.Drawing.Size(154, 34);
            this.fastpay_btn.TabIndex = 7;
            this.fastpay_btn.Text = "FastPay";
            this.fastpay_btn.UseVisualStyleBackColor = true;
            this.fastpay_btn.Click += new System.EventHandler(this.fastpay_btn_Click);
            // 
            // changepin_btn
            // 
            this.changepin_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changepin_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.changepin_btn.Location = new System.Drawing.Point(29, 311);
            this.changepin_btn.Name = "changepin_btn";
            this.changepin_btn.Size = new System.Drawing.Size(154, 34);
            this.changepin_btn.TabIndex = 8;
            this.changepin_btn.Text = "Change Pin";
            this.changepin_btn.UseVisualStyleBackColor = true;
            this.changepin_btn.Click += new System.EventHandler(this.changepin_btn_Click);
            // 
            // transaction_btn
            // 
            this.transaction_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transaction_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.transaction_btn.Location = new System.Drawing.Point(624, 140);
            this.transaction_btn.Name = "transaction_btn";
            this.transaction_btn.Size = new System.Drawing.Size(154, 58);
            this.transaction_btn.TabIndex = 9;
            this.transaction_btn.Text = "Previous Transaction";
            this.transaction_btn.UseVisualStyleBackColor = true;
            this.transaction_btn.Click += new System.EventHandler(this.transaction_btn_Click);
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdraw_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.withdraw_btn.Location = new System.Drawing.Point(624, 225);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(154, 34);
            this.withdraw_btn.TabIndex = 10;
            this.withdraw_btn.Text = "Withdraw";
            this.withdraw_btn.UseVisualStyleBackColor = true;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // balance_btn
            // 
            this.balance_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balance_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.balance_btn.Location = new System.Drawing.Point(624, 311);
            this.balance_btn.Name = "balance_btn";
            this.balance_btn.Size = new System.Drawing.Size(154, 34);
            this.balance_btn.TabIndex = 11;
            this.balance_btn.Text = "Balance";
            this.balance_btn.UseVisualStyleBackColor = true;
            this.balance_btn.Click += new System.EventHandler(this.balance_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Location = new System.Drawing.Point(1, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 13);
            this.panel2.TabIndex = 2;
            // 
            // logout_btn
            // 
            this.logout_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.logout_btn.Location = new System.Drawing.Point(1, 396);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(99, 34);
            this.logout_btn.TabIndex = 13;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CustomerP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.balance_btn);
            this.Controls.Add(this.withdraw_btn);
            this.Controls.Add(this.transaction_btn);
            this.Controls.Add(this.changepin_btn);
            this.Controls.Add(this.fastpay_btn);
            this.Controls.Add(this.deposit_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerP";
            this.Load += new System.EventHandler(this.CustomerP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label customerid_lb;
        private Button deposit_btn;
        private Button fastpay_btn;
        private Button changepin_btn;
        private Button transaction_btn;
        private Button withdraw_btn;
        private Button balance_btn;
        private Panel panel2;
        private Button logout_btn;
        private Label date_lb;
        private System.Windows.Forms.Timer timer1;
    }
}