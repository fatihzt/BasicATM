namespace BasicATM.WindowsForm
{
    partial class ChangePinP
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
            this.type_lb = new System.Windows.Forms.Label();
            this.customerid_lb = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.Label();
            this.pin_lb = new System.Windows.Forms.Label();
            this.changepin_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmpin_text = new System.Windows.Forms.TextBox();
            this.change_btn = new System.Windows.Forms.Button();
            this.date_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.type_lb);
            this.panel1.Controls.Add(this.customerid_lb);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 38);
            this.panel1.TabIndex = 3;
            // 
            // type_lb
            // 
            this.type_lb.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.type_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.type_lb.ForeColor = System.Drawing.Color.SeaShell;
            this.type_lb.Location = new System.Drawing.Point(143, 0);
            this.type_lb.Name = "type_lb";
            this.type_lb.Size = new System.Drawing.Size(147, 38);
            this.type_lb.TabIndex = 10;
            this.type_lb.Text = "Change Pin";
            this.type_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.back_btn.Location = new System.Drawing.Point(285, 358);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(154, 34);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 10);
            this.panel2.TabIndex = 16;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.SeaShell;
            this.Username.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Username.Location = new System.Drawing.Point(97, 41);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 24);
            this.Username.TabIndex = 17;
            this.Username.Text = "Old Pin";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pin_lb
            // 
            this.pin_lb.AutoSize = true;
            this.pin_lb.Location = new System.Drawing.Point(203, 41);
            this.pin_lb.Name = "pin_lb";
            this.pin_lb.Size = new System.Drawing.Size(38, 15);
            this.pin_lb.TabIndex = 11;
            this.pin_lb.Text = "label1";
            // 
            // changepin_text
            // 
            this.changepin_text.Location = new System.Drawing.Point(240, 151);
            this.changepin_text.Multiline = true;
            this.changepin_text.Name = "changepin_text";
            this.changepin_text.Size = new System.Drawing.Size(112, 38);
            this.changepin_text.TabIndex = 18;
            this.changepin_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(63, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Pin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(63, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Confirm Pin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmpin_text
            // 
            this.confirmpin_text.Location = new System.Drawing.Point(240, 220);
            this.confirmpin_text.Multiline = true;
            this.confirmpin_text.Name = "confirmpin_text";
            this.confirmpin_text.Size = new System.Drawing.Size(112, 38);
            this.confirmpin_text.TabIndex = 20;
            this.confirmpin_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // change_btn
            // 
            this.change_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.change_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.change_btn.Location = new System.Drawing.Point(143, 282);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(147, 34);
            this.change_btn.TabIndex = 21;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // date_lb
            // 
            this.date_lb.BackColor = System.Drawing.Color.SeaShell;
            this.date_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.date_lb.Location = new System.Drawing.Point(285, 0);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(151, 38);
            this.date_lb.TabIndex = 22;
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChangePinP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(439, 404);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.confirmpin_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changepin_text);
            this.Controls.Add(this.pin_lb);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePinP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePinP";
            this.Load += new System.EventHandler(this.ChangePinP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label type_lb;
        private Label customerid_lb;
        private Button back_btn;
        private Panel panel2;
        private Label Username;
        private Label pin_lb;
        private TextBox changepin_text;
        private Label label3;
        private Label label1;
        private TextBox confirmpin_text;
        private Button change_btn;
        private Label date_lb;
        private System.Windows.Forms.Timer timer1;
    }
}