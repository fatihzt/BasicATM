using System;
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
    public partial class CustomerP : Form
    {
        public static int CustomerId ;
        public CustomerP()
        {
            InitializeComponent();
        }
        
        private void deposit_btn_Click(object sender, EventArgs e)
        {

            customerid_lb.Text = CustomerId.ToString();
            DepositP depositP=new DepositP();
            depositP.Show();
            this.Hide();

        }

        private void CustomerP_Load(object sender, EventArgs e)
        {
            timer1.Start();
            customerid_lb.Text = LoginP.CustomerId.ToString();
            CustomerId=Convert.ToInt32( customerid_lb.Text);
        }

        

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ATM", new Font("Arial", 35, FontStyle.Bold), Brushes.Red, new Point(230));
        }

        private void balance_btn_Click(object sender, EventArgs e)
        {
            BalanceP balanceP = new BalanceP();
            balanceP.Show();
            this.Hide();
        }

        private void fastpay_btn_Click(object sender, EventArgs e)
        {
            FastPayP fastPayP = new FastPayP();
            fastPayP.Show();
            this.Hide();
        }

        private void withdraw_btn_Click(object sender, EventArgs e)
        {
            WithdrawP withdrawP = new WithdrawP();
            withdrawP.Show();
            this.Hide();
        }

        private void changepin_btn_Click(object sender, EventArgs e)
        {
            ChangePinP changePinP = new ChangePinP();
            changePinP.Show();
            this.Hide();

        }

        private void transaction_btn_Click(object sender, EventArgs e)
        {
            PreviousTransactionP previousTransactionP= new PreviousTransactionP();
            previousTransactionP.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginP loginP = new LoginP();
            loginP.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");

        }
    }
}
