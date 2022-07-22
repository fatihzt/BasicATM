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
    public partial class RegisterP : Form
    {
        public RegisterP()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            LoginP loginP = new LoginP();
            loginP.Show();
            this.Hide();
        }

        private void regreg_btn_Click(object sender, EventArgs e)
        {
            
            Model.Customer customer = new Model.Customer();
            if(namereg_text.Text!="" && cardnumber_text.Text!="" && agereg_text.Text != "" && phone_text.Text != "" && addressreg_text.Text != "" && pinreg_text.Text != "" && usernamereg_text.Text != "")
            {
                customer.Name = namereg_text.Text;
                customer.CardNumber = cardnumber_text.Text;
                customer.Age = agereg_text.Text;
                customer.Phone = phone_text.Text;
                customer.Address = addressreg_text.Text;
                customer.Pin = pinreg_text.Text;
                customer.Username = usernamereg_text.Text;
                customer.IsCreditCard = cardtype_box.Checked;
                CustomerManager.Create(customer);
                MessageBox.Show("Successfully Registered!", caption: "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                namereg_text.Clear();
                cardnumber_text.Clear();
                agereg_text.Clear();
                phone_text.Clear();
                addressreg_text.Clear();
                pinreg_text.Clear();
                usernamereg_text.Clear();
                cardtype_box.Checked = false;

            }
            else
            {
                MessageBox.Show("Fill in the all blanks please", caption: "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterP_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Now.ToString("HH:mm:ss tt");

        }
    }
}
