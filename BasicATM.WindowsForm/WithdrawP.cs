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
    public partial class WithdrawP : Form
    {
        public WithdrawP()
        {
            InitializeComponent();
        }

        private void WithdrawP_Load(object sender, EventArgs e)
        {
            timer1.Start();
            customerid_lb.Text = CustomerP.CustomerId.ToString();

            balance_lb.Text = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();
        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            
            int withdrawamount = Convert
                .ToInt32(withrawamount_text.Text);
            int oldbalance = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance;
            Model.Transaction transaction = new Model.Transaction();
            transaction.CustomerId = Convert.ToInt32(customerid_lb.Text);
            transaction.Type = Model.TransactionType.Withdraw;
            transaction.Amount = withdrawamount;
            transaction.TDate = DateTime.Now.ToString("HH:mm:ss tt");
            if (oldbalance >= withdrawamount)
            {
                CustomerManager.UpdateCustomersBalance(oldbalance - withdrawamount, Convert.ToInt32(customerid_lb.Text));
                TransactionManager.Create(transaction);
                MessageBox.Show(withrawamount_text.Text + "$ transfered!", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            balance_lb.Text = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();
            withrawamount_text.Clear();
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            CustomerP customerP = new CustomerP();
            customerP.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");

        }
    }
}
