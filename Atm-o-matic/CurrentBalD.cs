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
    public partial class CurrentBalD : Form
    {
        Deposit deposit;
        public CurrentBalD(Deposit dep)
        {
            InitializeComponent();
            this.deposit = dep;
        }

        private void CurrentBalD_Load(object sender, EventArgs e)
        {
            txtBals.Text = deposit.txtBal.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.ShowDialog();
        }
    }
}
