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
    public partial class LoginP : Form
    {
        
        public static int CustomerId ;
        public LoginP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterP registerP = new RegisterP();
            registerP.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var customer = CustomerManager.GetCustomerLogin(cardnumber_text.Text, pin_text.Text,comboBox1.SelectedItem=="Credit Card");
            if (customer.Id > 0)
            {
                CustomerId = customer.Id;
                CustomerP customerP = new CustomerP();
                customerP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Missing or Wrong Information Please Try Again!", caption: "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginP_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
