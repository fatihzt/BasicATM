using System;
using BasicATM.Core;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicATM.WindowsForm
{
    public partial class PreviousTransactionP : Form
    {
        public PreviousTransactionP()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            CustomerP customerP = new CustomerP();
            customerP.Show();
            this.Hide();

        }
        void TakeTransactionInformation()
        {
            customerid_lb.Text = CustomerP.CustomerId.ToString();
            transactionslist.DataSource=TransactionManager.GetTransactionById(Convert.ToInt32(customerid_lb.Text));
            
        }
        private void PreviousTransactionP_Load(object sender, EventArgs e)
        {
            timer1.Start();
            customerid_lb.Text = CustomerP.CustomerId.ToString();
            TakeTransactionInformation();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");

        }

        private void transactionslist_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private string SelectedRowInformation()
        {
            string var1 = transactionslist.SelectedRows[0].Cells[0].Value?.ToString()?? "";
            string var2= transactionslist.SelectedRows[0].Cells[1].Value?.ToString() ?? "";
            string var3= transactionslist.SelectedRows[0].Cells[2].Value?.ToString() ?? "";
            string var4= transactionslist.SelectedRows[0].Cells[3].Value?.ToString() ?? "";
            string var5= transactionslist.SelectedRows[0].Cells[4].Value?.ToString() ?? "";
            string var = var1 +" "+ var2 +" "+ var3 +" "+ var4 +" "+ var5 +" ";
            return var;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics?.DrawString("ATM ", new Font("Arial", 35, FontStyle.Regular), Brushes.Azure, new Point(230));
            e.Graphics?.DrawString(SelectedRowInformation(), new Font("Arial", 25, FontStyle.Italic), Brushes.OrangeRed, new Point(130));
            
        }
    }
}
