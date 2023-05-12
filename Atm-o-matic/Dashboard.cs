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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            this.Hide();
            withdraw.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Balance bal =new Balance();
            this.Hide();
            bal.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            this.Hide();
            dep.ShowDialog();
        }
    }
}
