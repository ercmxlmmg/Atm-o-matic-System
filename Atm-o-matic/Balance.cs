using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atm_o_matic
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            lblName.Text = "Juan Dela Cruz";
        }

        private void lblNum_Click(object sender, EventArgs e)
        {
            lblNum.Text = "************4567";
        }

        private void lblBal_Click(object sender, EventArgs e)
        {
            lblBal.Text = "₱13,000.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
