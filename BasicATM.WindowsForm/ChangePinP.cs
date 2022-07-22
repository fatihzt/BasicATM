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
    public partial class ChangePinP : Form
    {
        public ChangePinP()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            CustomerP customerP = new CustomerP();
            customerP.Show();
            this.Hide();
        }

        private void ChangePinP_Load(object sender, EventArgs e)
        {
            timer1.Start();
            customerid_lb.Text = CustomerP.CustomerId.ToString();
            pin_lb.Text = CustomerManager.GetCustomerById(Convert.ToInt32(customerid_lb.Text)).Pin;

        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            if (changepin_text.Text == confirmpin_text.Text)
            {
                CustomerManager.UpdateCustomersPin(confirmpin_text.Text, Convert.ToInt32(customerid_lb.Text));
                MessageBox.Show("Pin Changed!", caption: "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pin_lb.Text=confirmpin_text.Text;
                changepin_text.Clear();
                confirmpin_text.Clear();
            }
            else
            {
                MessageBox.Show("Pins Are Not Same Please Fix!", caption: "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");

        }
    }
}
