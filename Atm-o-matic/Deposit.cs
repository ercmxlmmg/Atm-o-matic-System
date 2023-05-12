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
    public partial class Deposit : Form
    {

        DataTable table = new DataTable();
        int index;

       

        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Account Name");
            table.Columns.Add("Account Number");
            table.Columns.Add("Amount Deposit");
            table.Columns.Add("Balance");
            table.Columns.Add("Date & Time");
            dataGridView1.DataSource = table;

            lblDate.Text = DateTime.Now.ToString("dd MMMM, yyyy/hh:mm:ss tt");

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            lblNames.Text = row.Cells[1].Value.ToString();
            lblNumb.Text = row.Cells[2].Value.ToString();
            txtAmt.Text = row.Cells[3].Value.ToString();
            lblBals.Text = row.Cells[4].Value.ToString();
            lblDate.Text = row.Cells[5].Value.ToString();

            lblDate.Text = DateTime.Now.ToString("dd MMMM, yyyy/hh:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bal = 13000;
            double amt;
            double total;

            amt = Convert.ToDouble(txtAmt.Text);
            total = bal +  amt;
            lblBals.Text = ("₱" + total.ToString());
            lblAmts.Text = txtAmt.Text;
            txtBal.Text = lblBals.Text;

            table.Rows.Add(lblNames.Text, lblNumb.Text, txtAmt.Text, lblBals.Text, lblDate.Text);

        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd MMMM, yyyy/hh:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            this.Hide();
            dash.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CurrentBalD dash = new CurrentBalD(this);
            this.Hide();
            dash.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            int number = +1;
            txtAmt.Text += number;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int number = +2;
            txtAmt.Text += number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = +3;
            txtAmt.Text += number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = +4;
            txtAmt.Text += number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = +5;
            txtAmt.Text += number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = +6;
            txtAmt.Text += number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = +7;
            txtAmt.Text += number;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int number = +8;
            txtAmt.Text += number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = +9;
            txtAmt.Text += number;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int number = +0;
            txtAmt.Text += number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtAmt.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtAmt.Text, "") < 0)
            {
                txtAmt.Text = txtAmt.Text.Substring(0, txtAmt.Text.Length - 1 + 1);
            }
            else

                txtAmt.Text = txtAmt.Text.Substring(0, txtAmt.Text.Length - 1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double bal = 13000;
            double total;
            double amt;
            amt = Convert.ToDouble(txtAmt.Text);

           
                amt = Convert.ToDouble(txtAmt.Text);
                total = bal + amt;
                lblBals.Text = ("₱" + total.ToString());
                lblAmt.Text = txtAmt.Text;
            txtBal.Text = lblBals.Text;

                table.Rows.Add(lblNames.Text, lblNumb.Text, txtAmt.Text, lblBals.Text, lblDate.Text);
            
          
        }
    }
}

