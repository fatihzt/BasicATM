namespace BasicATM.WindowsForm
{
    partial class FastPayP
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
            this.label2 = new System.Windows.Forms.Label();
            this.customerid_lb = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.balance_lb = new System.Windows.Forms.Label();
            this.fifty_btn = new System.Windows.Forms.Button();
            this.thousand_btn = new System.Windows.Forms.Button();
            this.fivethousand = new System.Windows.Forms.Button();
            this.twohundred_btn = new System.Windows.Forms.Button();
            this.fivehundred_btn = new System.Windows.Forms.Button();
            this.hundred_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customerid_lb);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 38);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(143, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "FastPay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerid_lb
            // 
            this.customerid_lb.AutoSize = true;
            this.customerid_lb.ForeColor = System.Drawing.Color.SeaShell;
            this.customerid_lb.Location = new System.Drawing.Point(0, 0);
            this.customerid_lb.Name = "customerid_lb";
            this.customerid_lb.Size = new System.Drawing.Size(38, 15);
            this.customerid_lb.TabIndex = 0;
            this.customerid_lb.Text = "label1";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.SeaShell;
            this.Username.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Username.Location = new System.Drawing.Point(111, 41);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 24);
            this.Username.TabIndex = 6;
            this.Username.Text = "Balance";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balance_lb
            // 
            this.balance_lb.BackColor = System.Drawing.Color.SeaShell;
            this.balance_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.balance_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.balance_lb.Location = new System.Drawing.Point(222, 41);
            this.balance_lb.Name = "balance_lb";
            this.balance_lb.Size = new System.Drawing.Size(100, 24);
            this.balance_lb.TabIndex = 7;
            this.balance_lb.Text = "label1";
            this.balance_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fifty_btn
            // 
            this.fifty_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fifty_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.fifty_btn.Location = new System.Drawing.Point(46, 99);
            this.fifty_btn.Name = "fifty_btn";
            this.fifty_btn.Size = new System.Drawing.Size(65, 49);
            this.fifty_btn.TabIndex = 8;
            this.fifty_btn.Text = "50";
            this.fifty_btn.UseVisualStyleBackColor = true;
            this.fifty_btn.Click += new System.EventHandler(this.fifty_btn_Click);
            // 
            // thousand_btn
            // 
            this.thousand_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thousand_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.thousand_btn.Location = new System.Drawing.Point(46, 248);
            this.thousand_btn.Name = "thousand_btn";
            this.thousand_btn.Size = new System.Drawing.Size(65, 49);
            this.thousand_btn.TabIndex = 9;
            this.thousand_btn.Text = "1000";
            this.thousand_btn.UseVisualStyleBackColor = true;
            this.thousand_btn.Click += new System.EventHandler(this.thousand_btn_Click);
            // 
            // fivethousand
            // 
            this.fivethousand.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fivethousand.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.fivethousand.Location = new System.Drawing.Point(324, 248);
            this.fivethousand.Name = "fivethousand";
            this.fivethousand.Size = new System.Drawing.Size(65, 49);
            this.fivethousand.TabIndex = 10;
            this.fivethousand.Text = "5000";
            this.fivethousand.UseVisualStyleBackColor = true;
            this.fivethousand.Click += new System.EventHandler(this.fivethousand_Click);
            // 
            // twohundred_btn
            // 
            this.twohundred_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.twohundred_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.twohundred_btn.Location = new System.Drawing.Point(46, 175);
            this.twohundred_btn.Name = "twohundred_btn";
            this.twohundred_btn.Size = new System.Drawing.Size(65, 49);
            this.twohundred_btn.TabIndex = 11;
            this.twohundred_btn.Text = "200";
            this.twohundred_btn.UseVisualStyleBackColor = true;
            this.twohundred_btn.Click += new System.EventHandler(this.twohundred_btn_Click);
            // 
            // fivehundred_btn
            // 
            this.fivehundred_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fivehundred_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.fivehundred_btn.Location = new System.Drawing.Point(324, 175);
            this.fivehundred_btn.Name = "fivehundred_btn";
            this.fivehundred_btn.Size = new System.Drawing.Size(65, 49);
            this.fivehundred_btn.TabIndex = 12;
            this.fivehundred_btn.Text = "500";
            this.fivehundred_btn.UseVisualStyleBackColor = true;
            this.fivehundred_btn.Click += new System.EventHandler(this.fivehundred_btn_Click);
            // 
            // hundred_btn
            // 
            this.hundred_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hundred_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.hundred_btn.Location = new System.Drawing.Point(324, 99);
            this.hundred_btn.Name = "hundred_btn";
            this.hundred_btn.Size = new System.Drawing.Size(65, 49);
            this.hundred_btn.TabIndex = 13;
            this.hundred_btn.Text = "100";
            this.hundred_btn.UseVisualStyleBackColor = true;
            this.hundred_btn.Click += new System.EventHandler(this.hundred_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.back_btn.Location = new System.Drawing.Point(286, 302);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(154, 34);
            this.back_btn.TabIndex = 14;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Location = new System.Drawing.Point(1, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 10);
            this.panel2.TabIndex = 15;
            // 
            // date_lb
            // 
            this.date_lb.BackColor = System.Drawing.Color.SeaShell;
            this.date_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.date_lb.Location = new System.Drawing.Point(286, 0);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(154, 41);
            this.date_lb.TabIndex = 16;
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FastPayP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(442, 348);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.hundred_btn);
            this.Controls.Add(this.fivehundred_btn);
            this.Controls.Add(this.twohundred_btn);
            this.Controls.Add(this.fivethousand);
            this.Controls.Add(this.thousand_btn);
            this.Controls.Add(this.fifty_btn);
            this.Controls.Add(this.balance_lb);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastPayP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastPayP";
            this.Load += new System.EventHandler(this.FastPayP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label customerid_lb;
        private Label label2;
        private Label Username;
        private Label balance_lb;
        private Button fifty_btn;
        private Button thousand_btn;
        private Button fivethousand;
        private Button twohundred_btn;
        private Button fivehundred_btn;
        private Button hundred_btn;
        private Button back_btn;
        private Panel panel2;
        private Label date_lb;
        private System.Windows.Forms.Timer timer1;
    }
}