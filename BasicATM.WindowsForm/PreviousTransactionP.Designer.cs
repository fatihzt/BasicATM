namespace BasicATM.WindowsForm
{
    partial class PreviousTransactionP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviousTransactionP));
            this.transactionslist = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_lb = new System.Windows.Forms.Label();
            this.type_lb = new System.Windows.Forms.Label();
            this.customerid_lb = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.transactionslist)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactionslist
            // 
            this.transactionslist.AllowUserToAddRows = false;
            this.transactionslist.AllowUserToDeleteRows = false;
            this.transactionslist.BackgroundColor = System.Drawing.Color.SeaShell;
            this.transactionslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionslist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerId,
            this.Type,
            this.Amount,
            this.TDate});
            this.transactionslist.Location = new System.Drawing.Point(2, 80);
            this.transactionslist.Name = "transactionslist";
            this.transactionslist.ReadOnly = true;
            this.transactionslist.RowTemplate.Height = 25;
            this.transactionslist.Size = new System.Drawing.Size(550, 295);
            this.transactionslist.TabIndex = 0;
            this.transactionslist.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.transactionslist_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // TDate
            // 
            this.TDate.DataPropertyName = "TDate";
            this.TDate.HeaderText = "TransactionDate";
            this.TDate.Name = "TDate";
            this.TDate.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.date_lb);
            this.panel1.Controls.Add(this.type_lb);
            this.panel1.Controls.Add(this.customerid_lb);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 38);
            this.panel1.TabIndex = 4;
            // 
            // date_lb
            // 
            this.date_lb.BackColor = System.Drawing.Color.SeaShell;
            this.date_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.date_lb.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.date_lb.Location = new System.Drawing.Point(376, 0);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(174, 38);
            this.date_lb.TabIndex = 18;
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // type_lb
            // 
            this.type_lb.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.type_lb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.type_lb.ForeColor = System.Drawing.Color.SeaShell;
            this.type_lb.Location = new System.Drawing.Point(155, 0);
            this.type_lb.Name = "type_lb";
            this.type_lb.Size = new System.Drawing.Size(224, 38);
            this.type_lb.TabIndex = 10;
            this.type_lb.Text = "Previous Transactions";
            this.type_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerid_lb
            // 
            this.customerid_lb.AutoSize = true;
            this.customerid_lb.ForeColor = System.Drawing.Color.SeaShell;
            this.customerid_lb.Location = new System.Drawing.Point(-1, 0);
            this.customerid_lb.Name = "customerid_lb";
            this.customerid_lb.Size = new System.Drawing.Size(38, 15);
            this.customerid_lb.TabIndex = 0;
            this.customerid_lb.Text = "label1";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_btn.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.back_btn.Location = new System.Drawing.Point(398, 404);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(154, 34);
            this.back_btn.TabIndex = 16;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Location = new System.Drawing.Point(2, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 10);
            this.panel2.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PreviousTransactionP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transactionslist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreviousTransactionP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreviousTransactionP";
            this.Load += new System.EventHandler(this.PreviousTransactionP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionslist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView transactionslist;
        private Panel panel1;
        private Label type_lb;
        private Label customerid_lb;
        private Button back_btn;
        private Panel panel2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn TDate;
        private Label date_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}