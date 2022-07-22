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
    public partial class DepositP : Form
    {
        
        public DepositP()
        {
            InitializeComponent();
        }
        
        private void DepositP_Load(object sender, EventArgs e)
        {
            timer1.Start();
            customerid_lb.Text = CustomerP.CustomerId.ToString();
        }
        
        private void back_btn_Click(object sender, EventArgs e)
        {
            CustomerP customerP = new CustomerP();
            customerP.Show();
            this.Hide();
            
        }
        
        private void deposit_btn_Click(object sender, EventArgs e)
        {
            Model.Transaction transaction = new Model.Transaction();
            transaction.CustomerId = Convert.ToInt32(customerid_lb.Text);
            transaction.Amount = Convert.ToInt32(deposit_text.Text);
            transaction.Type = Model.TransactionType.Deposit;
            transaction.TDate = DateTime.Now.ToString("HH:mm:ss tt");
            TransactionManager.Create(transaction);




            customerid_lb.Text = CustomerP.CustomerId.ToString();
            int oldbalance = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance;
            CustomerManager.UpdateCustomersBalance(Convert.ToInt32(deposit_text.Text) + oldbalance,Convert.ToInt32(customerid_lb.Text));
            MessageBox.Show(deposit_text.Text+"$ Deposit Your Card", caption: "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            deposit_text.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");

        }
    }
}
