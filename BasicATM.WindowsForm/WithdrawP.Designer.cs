namespace BasicATM.WindowsForm
{
    partial class WithdrawP
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.type_lb = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.customerid_lb = new System.Windows.Forms.Label();
            this.withrawamount_text = new System.Windows.Forms.TextBox();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.balance_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.type_lb);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 35);
            this.panel2.TabIndex = 5;
            // 
            // type_lb
            // 
            this.type_lb.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.type_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.type_lb.ForeColor = System.Drawing.Color.SeaShell;
            this.type_lb.Location = new System.Drawing.Point(130, 1);
            this.type_lb.Name = "type_lb";
            this.type_lb.Size = new System.Drawing.Size(147, 34);
            this.type_lb.TabIndex = 9;
            this.type_lb.Text = "Withdraw";
            this.type_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.back_btn.Location = new System.Drawing.Point(249, 260);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(154, 34);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Location = new System.Drawing.Point(1, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 10);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(64, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "CustomerId";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerid_lb
            // 
            this.customerid_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerid_lb.ForeColor = System.Drawing.Color.SeaShell;
            this.customerid_lb.Location = new System.Drawing.Point(217, 40);
            this.customerid_lb.Name = "customerid_lb";
            this.customerid_lb.Size = new System.Drawing.Size(119, 34);
            this.customerid_lb.TabIndex = 18;
            this.customerid_lb.Text = "label1";
            this.customerid_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // withrawamount_text
            // 
            this.withrawamount_text.Location = new System.Drawing.Point(143, 134);
            this.withrawamount_text.Multiline = true;
            this.withrawamount_text.Name = "withrawamount_text";
            this.withrawamount_text.Size = new System.Drawing.Size(119, 35);
            this.withrawamount_text.TabIndex = 19;
            this.withrawamount_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdraw_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.withdraw_btn.Location = new System.Drawing.Point(131, 175);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(147, 34);
            this.withdraw_btn.TabIndex = 20;
            this.withdraw_btn.Text = "Withdraw";
            this.withdraw_btn.UseVisualStyleBackColor = true;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // balance_lb
            // 
            this.balance_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balance_lb.ForeColor = System.Drawing.Color.SeaShell;
            this.balance_lb.Location = new System.Drawing.Point(143, 86);
            this.balance_lb.Name = "balance_lb";
            this.balance_lb.Size = new System.Drawing.Size(119, 34);
            this.balance_lb.TabIndex = 21;
            this.balance_lb.Text = "label1";
            this.balance_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_lb
            // 
            this.date_lb.BackColor = System.Drawing.Color.SeaShell;
            this.date_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.date_lb.Location = new System.Drawing.Point(278, 3);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(125, 34);
            this.date_lb.TabIndex = 22;
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WithdrawP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(404, 306);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.balance_lb);
            this.Controls.Add(this.withdraw_btn);
            this.Controls.Add(this.withrawamount_text);
            this.Controls.Add(this.customerid_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WithdrawP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawP";
            this.Load += new System.EventHandler(this.WithdrawP_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Label type_lb;
        private Button back_btn;
        private Panel panel1;
        private Label label2;
        private Label customerid_lb;
        private TextBox withrawamount_text;
        private Button withdraw_btn;
        private Label balance_lb;
        private Label date_lb;
        private System.Windows.Forms.Timer timer1;
    }
}