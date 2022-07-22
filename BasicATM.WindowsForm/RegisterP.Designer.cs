namespace BasicATM.WindowsForm
{
    partial class RegisterP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_lb = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.phone_text = new System.Windows.Forms.TextBox();
            this.usernamereg_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressreg_lb = new System.Windows.Forms.Label();
            this.agereg_lb = new System.Windows.Forms.Label();
            this.pinreg_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regreg_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.agereg_text = new System.Windows.Forms.TextBox();
            this.addressreg_text = new System.Windows.Forms.TextBox();
            this.namereg_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cardnumber_text = new System.Windows.Forms.TextBox();
            this.cardtype_box = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.date_lb);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 61);
            this.panel1.TabIndex = 0;
            // 
            // date_lb
            // 
            this.date_lb.BackColor = System.Drawing.Color.SeaShell;
            this.date_lb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.date_lb.Location = new System.Drawing.Point(476, 0);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(140, 61);
            this.date_lb.TabIndex = 26;
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.SeaShell;
            this.Username.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Username.Location = new System.Drawing.Point(311, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(112, 61);
            this.Username.TabIndex = 2;
            this.Username.Text = "ATM";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phone_text
            // 
            this.phone_text.Location = new System.Drawing.Point(189, 210);
            this.phone_text.Multiline = true;
            this.phone_text.Name = "phone_text";
            this.phone_text.Size = new System.Drawing.Size(137, 23);
            this.phone_text.TabIndex = 8;
            this.phone_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernamereg_text
            // 
            this.usernamereg_text.Location = new System.Drawing.Point(189, 178);
            this.usernamereg_text.Multiline = true;
            this.usernamereg_text.Name = "usernamereg_text";
            this.usernamereg_text.Size = new System.Drawing.Size(137, 23);
            this.usernamereg_text.TabIndex = 7;
            this.usernamereg_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(28, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phone";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(28, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressreg_lb
            // 
            this.addressreg_lb.BackColor = System.Drawing.Color.SeaShell;
            this.addressreg_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressreg_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.addressreg_lb.Location = new System.Drawing.Point(398, 213);
            this.addressreg_lb.Name = "addressreg_lb";
            this.addressreg_lb.Size = new System.Drawing.Size(112, 23);
            this.addressreg_lb.TabIndex = 10;
            this.addressreg_lb.Text = "Address";
            this.addressreg_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agereg_lb
            // 
            this.agereg_lb.BackColor = System.Drawing.Color.SeaShell;
            this.agereg_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.agereg_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.agereg_lb.Location = new System.Drawing.Point(398, 178);
            this.agereg_lb.Name = "agereg_lb";
            this.agereg_lb.Size = new System.Drawing.Size(112, 23);
            this.agereg_lb.TabIndex = 9;
            this.agereg_lb.Text = "Age";
            this.agereg_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pinreg_text
            // 
            this.pinreg_text.Location = new System.Drawing.Point(189, 239);
            this.pinreg_text.Multiline = true;
            this.pinreg_text.Name = "pinreg_text";
            this.pinreg_text.Size = new System.Drawing.Size(137, 23);
            this.pinreg_text.TabIndex = 16;
            this.pinreg_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(28, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pin";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regreg_btn
            // 
            this.regreg_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regreg_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.regreg_btn.Location = new System.Drawing.Point(559, 305);
            this.regreg_btn.Name = "regreg_btn";
            this.regreg_btn.Size = new System.Drawing.Size(154, 34);
            this.regreg_btn.TabIndex = 7;
            this.regreg_btn.Text = "Register";
            this.regreg_btn.UseVisualStyleBackColor = true;
            this.regreg_btn.Click += new System.EventHandler(this.regreg_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.back_btn.Location = new System.Drawing.Point(559, 345);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(154, 34);
            this.back_btn.TabIndex = 17;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Location = new System.Drawing.Point(2, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 16);
            this.panel2.TabIndex = 18;
            // 
            // agereg_text
            // 
            this.agereg_text.Location = new System.Drawing.Point(559, 178);
            this.agereg_text.Multiline = true;
            this.agereg_text.Name = "agereg_text";
            this.agereg_text.Size = new System.Drawing.Size(137, 23);
            this.agereg_text.TabIndex = 19;
            this.agereg_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addressreg_text
            // 
            this.addressreg_text.Location = new System.Drawing.Point(559, 213);
            this.addressreg_text.Multiline = true;
            this.addressreg_text.Name = "addressreg_text";
            this.addressreg_text.Size = new System.Drawing.Size(137, 55);
            this.addressreg_text.TabIndex = 20;
            this.addressreg_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // namereg_text
            // 
            this.namereg_text.Location = new System.Drawing.Point(189, 145);
            this.namereg_text.Multiline = true;
            this.namereg_text.Name = "namereg_text";
            this.namereg_text.Size = new System.Drawing.Size(137, 23);
            this.namereg_text.TabIndex = 22;
            this.namereg_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(28, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SeaShell;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(398, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "CardNumber";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardnumber_text
            // 
            this.cardnumber_text.Location = new System.Drawing.Point(559, 142);
            this.cardnumber_text.Multiline = true;
            this.cardnumber_text.Name = "cardnumber_text";
            this.cardnumber_text.Size = new System.Drawing.Size(137, 23);
            this.cardnumber_text.TabIndex = 24;
            this.cardnumber_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardtype_box
            // 
            this.cardtype_box.AutoSize = true;
            this.cardtype_box.BackColor = System.Drawing.Color.SeaShell;
            this.cardtype_box.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cardtype_box.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cardtype_box.Location = new System.Drawing.Point(395, 245);
            this.cardtype_box.Name = "cardtype_box";
            this.cardtype_box.Size = new System.Drawing.Size(115, 23);
            this.cardtype_box.TabIndex = 25;
            this.cardtype_box.Text = "Credit Card";
            this.cardtype_box.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RegisterP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(719, 397);
            this.Controls.Add(this.cardtype_box);
            this.Controls.Add(this.cardnumber_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namereg_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressreg_text);
            this.Controls.Add(this.agereg_text);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.regreg_btn);
            this.Controls.Add(this.pinreg_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressreg_lb);
            this.Controls.Add(this.agereg_lb);
            this.Controls.Add(this.phone_text);
            this.Controls.Add(this.usernamereg_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterP";
            this.Load += new System.EventHandler(this.RegisterP_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Username;
        private TextBox phone_text;
        private TextBox usernamereg_text;
        private Label label1;
        private Label label2;
        private Label addressreg_lb;
        private Label agereg_lb;
        private TextBox pinreg_text;
        private Label label5;
        private Button regreg_btn;
        private Button back_btn;
        private Panel panel2;
        private TextBox agereg_text;
        private TextBox addressreg_text;
        private TextBox namereg_text;
        private Label label3;
        private Label label4;
        private TextBox cardnumber_text;
        private CheckBox cardtype_box;
        private Label date_lb;
        private System.Windows.Forms.Timer timer1;
    }
}