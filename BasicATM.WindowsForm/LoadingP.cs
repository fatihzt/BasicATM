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
    public partial class LoadingP : Form
    {
        public LoadingP()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint++;
            loadingbar.Value = startpoint;
            if (loadingbar.Value == 100)
            {
                loadingbar.Value = 0;
                timer1.Stop();
                LoginP loginP = new LoginP();
                loginP.Show();
                this.Hide();
            }

        }

        private void LoadingP_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
