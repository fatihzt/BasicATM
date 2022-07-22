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
    public partial class BalanceP : Form
    {
        public BalanceP()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            CustomerP customerP = new CustomerP();
            customerP.Show();
            this.Hide();
        }

        private void BalanceP_Load(object sender, EventArgs e)
        {
            timer1.Start();
            customerid_lb.Text=CustomerP.CustomerId.ToString();
            balance_lb.Text = CustomerManager.GetCustomersBalanceById(Convert.ToInt32(customerid_lb.Text)).Balance.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");

        }
    }
}
