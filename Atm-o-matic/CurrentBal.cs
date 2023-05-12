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
    public partial class CurrentBal : Form
    {
        Withdraw withdraw;
        
        public CurrentBal(Withdraw with)
        {
            InitializeComponent();
            this.withdraw = with;
        }

        private void CurrentBal_Load(object sender, EventArgs e)
        {
            txtBals.Text = withdraw.txtBal.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.ShowDialog();
        }
    }
}
