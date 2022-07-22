namespace BasicATM.WindowsForm
{
    partial class LoginP
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardnumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cardnumber_text = new System.Windows.Forms.TextBox();
            this.pin_text = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.date_lb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 385);
            this.panel1.TabIndex = 0;
            // 
            // date_lb
            // 
            this.date_lb.BackColor = System.Drawing.Color.SeaShell;
            this.date_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.date_lb.Location = new System.Drawing.Point(3, 258);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(199, 67);
            this.date_lb.TabIndex = 2;
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasicATM.WindowsForm.Properties.Resources.atm_machine__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cardnumber
            // 
            this.cardnumber.BackColor = System.Drawing.Color.SeaShell;
            this.cardnumber.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardnumber.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cardnumber.Location = new System.Drawing.Point(250, 127);
            this.cardnumber.Name = "cardnumber";
            this.cardnumber.Size = new System.Drawing.Size(112, 49);
            this.cardnumber.TabIndex = 1;
            this.cardnumber.Text = "Card Number";
            this.cardnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(250, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardnumber_text
            // 
            this.cardnumber_text.Location = new System.Drawing.Point(411, 153);
            this.cardnumber_text.Multiline = true;
            this.cardnumber_text.Name = "cardnumber_text";
            this.cardnumber_text.Size = new System.Drawing.Size(137, 23);
            this.cardnumber_text.TabIndex = 3;
            this.cardnumber_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pin_text
            // 
            this.pin_text.Location = new System.Drawing.Point(411, 192);
            this.pin_text.Multiline = true;
            this.pin_text.Name = "pin_text";
            this.pin_text.Size = new System.Drawing.Size(137, 23);
            this.pin_text.TabIndex = 4;
            this.pin_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.login_btn.Location = new System.Drawing.Point(495, 292);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(154, 34);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.register_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.register_btn.Location = new System.Drawing.Point(495, 332);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(154, 34);
            this.register_btn.TabIndex = 6;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Location = new System.Drawing.Point(211, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 14);
            this.panel2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card"});
            this.comboBox1.Location = new System.Drawing.Point(411, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Select Card Type";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(613, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(650, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pin_text);
            this.Controls.Add(this.cardnumber_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardnumber);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginP";
            this.Load += new System.EventHandler(this.LoginP_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label cardnumber;
        private Label label1;
        private TextBox cardnumber_text;
        private TextBox pin_text;
        private Button login_btn;
        private Button register_btn;
        private Panel panel2;
        private ComboBox comboBox1;
        private Button button1;
        private Label date_lb;
        private System.Windows.Forms.Timer timer1;
    }
}