namespace BasicATM.WindowsForm
{
    partial class DepositP
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
            this.date_lb = new System.Windows.Forms.Label();
            this.type_lb = new System.Windows.Forms.Label();
            this.customerid_lb = new System.Windows.Forms.Label();
            this.deposit_text = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.date_lb);
            this.panel2.Controls.Add(this.type_lb);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 35);
            this.panel2.TabIndex = 3;
            // 
            // date_lb
            // 
            this.date_lb.BackColor = System.Drawing.Color.SeaShell;
            this.date_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.date_lb.Location = new System.Drawing.Point(268, 1);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(134, 34);
            this.date_lb.TabIndex = 9;
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_lb
            // 
            this.type_lb.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.type_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.type_lb.ForeColor = System.Drawing.Color.SeaShell;
            this.type_lb.Location = new System.Drawing.Point(125, 1);
            this.type_lb.Name = "type_lb";
            this.type_lb.Size = new System.Drawing.Size(147, 34);
            this.type_lb.TabIndex = 8;
            this.type_lb.Text = "Deposit";
            this.type_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerid_lb
            // 
            this.customerid_lb.AutoSize = true;
            this.customerid_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.customerid_lb.Location = new System.Drawing.Point(2, 292);
            this.customerid_lb.Name = "customerid_lb";
            this.customerid_lb.Size = new System.Drawing.Size(38, 15);
            this.customerid_lb.TabIndex = 0;
            this.customerid_lb.Text = "label1";
            // 
            // deposit_text
            // 
            this.deposit_text.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit_text.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.deposit_text.Location = new System.Drawing.Point(253, 121);
            this.deposit_text.Multiline = true;
            this.deposit_text.Name = "deposit_text";
            this.deposit_text.Size = new System.Drawing.Size(147, 34);
            this.deposit_text.TabIndex = 4;
            this.deposit_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.SeaShell;
            this.Username.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Username.Location = new System.Drawing.Point(12, 121);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(147, 34);
            this.Username.TabIndex = 5;
            this.Username.Text = "Amount:";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Location = new System.Drawing.Point(2, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 10);
            this.panel1.TabIndex = 4;
            // 
            // deposit_btn
            // 
            this.deposit_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deposit_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.deposit_btn.Location = new System.Drawing.Point(127, 161);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(154, 34);
            this.deposit_btn.TabIndex = 7;
            this.deposit_btn.Text = "Deposit";
            this.deposit_btn.UseVisualStyleBackColor = true;
            this.deposit_btn.Click += new System.EventHandler(this.deposit_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.back_btn.Location = new System.Drawing.Point(246, 273);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(154, 34);
            this.back_btn.TabIndex = 8;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DepositP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(405, 316);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.deposit_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.deposit_text);
            this.Controls.Add(this.customerid_lb);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepositP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositP";
            this.Load += new System.EventHandler(this.DepositP_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Label customerid_lb;
        private TextBox deposit_text;
        private Label Username;
        private Panel panel1;
        private Label type_lb;
        private Button deposit_btn;
        private Button back_btn;
        private Label date_lb;
        private System.Windows.Forms.Timer timer1;
    }
}