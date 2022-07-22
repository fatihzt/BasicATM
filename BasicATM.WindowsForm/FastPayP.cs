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
    public partial class FastPayP : Form
    {
        public FastPayP()
        {
            InitializeComponent();
        }

        private void FastPayP_Load(object sender, EventArgs e)
        {
            timer1.Start();
            customerid_lb.Text = CustomerP.CustomerId.ToString();
            balance_lb.Text = CustomerManager.GetCustomerById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            CustomerP customerP = new CustomerP();
            customerP.Show();
            this.Hide();
        }
        private void fifty_btn_Click(object sender, EventArgs e)
        {
            Model.Transaction transaction = new Model.Transaction();
            transaction.CustomerId =Convert.ToInt32(customerid_lb.Text);
            transaction.Type = Model.TransactionType.FastPay;
            transaction.Amount = 50;
            transaction.TDate= DateTime.Now.ToString("HH:mm:ss tt");
            TransactionManager.Create(transaction);

            int oldbalance = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance;
            if (oldbalance >= 50)
            {
                CustomerManager.UpdateCustomersBalance(oldbalance - 50,Convert.ToInt32(customerid_lb.Text));
                MessageBox.Show("50$ Transfered!", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fakirsin ", caption: "Error");
            }
            balance_lb.Text = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();
        }

        private void hundred_btn_Click(object sender, EventArgs e)
        {
            Model.Transaction transaction = new Model.Transaction();
            transaction.CustomerId = Convert.ToInt32(customerid_lb.Text);
            transaction.Type = Model.TransactionType.FastPay;
            transaction.Amount = 100;
            transaction.TDate = DateTime.Now.ToString("HH:mm:ss tt");
            TransactionManager.Create(transaction);

            int oldbalance = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance;
            if (oldbalance >= 100)
            {
                CustomerManager.UpdateCustomersBalance(oldbalance - 100, Convert.ToInt32(customerid_lb.Text));
                MessageBox.Show("100$ Transfered!", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fakirsin ", caption: "Error");
            }
            balance_lb.Text = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();
        }

        private void twohundred_btn_Click(object sender, EventArgs e)
        {
            Model.Transaction transaction = new Model.Transaction();
            transaction.CustomerId = Convert.ToInt32(customerid_lb.Text);
            transaction.Type = Model.TransactionType.FastPay;
            transaction.Amount = 200;
            transaction.TDate = DateTime.Now.ToString("HH:mm:ss tt");
            TransactionManager.Create(transaction);

            int oldbalance = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance;
            if (oldbalance >= 200)
            {
                CustomerManager.UpdateCustomersBalance(oldbalance - 200, Convert.ToInt32(customerid_lb.Text));
                MessageBox.Show("200$ Transfered!", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fakirsin ", caption: "Error");
            }
            balance_lb.Text = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();
        }

        private void fivehundred_btn_Click(object sender, EventArgs e)
        {
            Model.Transaction transaction = new Model.Transaction();
            transaction.CustomerId = Convert.ToInt32(customerid_lb.Text);
            transaction.Type = Model.TransactionType.FastPay;
            transaction.Amount = 500;
            transaction.TDate = DateTime.Now.ToString("HH:mm:ss tt");
            TransactionManager.Create(transaction);

            int oldbalance = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance;
            if (oldbalance >= 500)
            {
                CustomerManager.UpdateCustomersBalance(oldbalance - 500, Convert.ToInt32(customerid_lb.Text));
                MessageBox.Show("500$ Transfered!", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fakirsin ", caption: "Error");
            }
            balance_lb.Text = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();
        }

        private void thousand_btn_Click(object sender, EventArgs e)
        {
            Model.Transaction transaction = new Model.Transaction();
            transaction.CustomerId = Convert.ToInt32(customerid_lb.Text);
            transaction.Type = Model.TransactionType.FastPay;
            transaction.Amount = 1000;
            transaction.TDate = DateTime.Now.ToString("HH:mm:ss tt");
            TransactionManager.Create(transaction);

            int oldbalance = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance;
            if (oldbalance >= 1000)
            {
                CustomerManager.UpdateCustomersBalance(oldbalance - 1000, Convert.ToInt32(customerid_lb.Text));
                MessageBox.Show("1000$ Transfered!", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fakirsin ", caption: "Error");
            }
            balance_lb.Text = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();

        }

        private void fivethousand_Click(object sender, EventArgs e)
        {
            Model.Transaction transaction = new Model.Transaction();
            transaction.CustomerId = Convert.ToInt32(customerid_lb.Text);
            transaction.Type = Model.TransactionType.FastPay;
            transaction.Amount = 5000;
            transaction.TDate = DateTime.Now.ToString("HH:mm:ss tt");
            TransactionManager.Create(transaction);

            int oldbalance = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance;
            if (oldbalance >= 5000)
            {
                CustomerManager.UpdateCustomersBalance(oldbalance - 5000, Convert.ToInt32(customerid_lb.Text));
                MessageBox.Show("5000$ Transfered!", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fakirsin ",caption:"Error");
            }
            balance_lb.Text = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");

        }
    }
}
