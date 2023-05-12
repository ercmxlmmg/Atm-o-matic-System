using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atm_o_matic
{
    public partial class Pin : Form
    {
        public int enterAttempt = 0;
        public Pin()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = +1;
            textBox1.Text += number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = +2;
            textBox1.Text += number;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = +3;
            textBox1.Text += number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int number = +4;
            textBox1.Text += number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = +5;
            textBox1.Text += number;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int number = +6;
            textBox1.Text += number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int number = +7;
            textBox1.Text += number;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int number = +8;
            textBox1.Text += number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int number = +9;
            textBox1.Text += number;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int number = +0;
            textBox1.Text += number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(String.Compare(textBox1.Text,"") < 0)
            {
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1 + 1);
            }
            else
            {   
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

       
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2222")
            {
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.ShowDialog();
            }
            else 
            {
                enterAttempt++;

                if (enterAttempt < 3)
                {
                    MessageBox.Show("Incorrect PIN! Please try again." + " " + (3 - enterAttempt) + " attempts more","Atm-o-matic", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Reset();
                } 
               if (enterAttempt == 3)
                {
                    MessageBox.Show("Sorry, you have exceeded the number of maximum attempts!", "Atm-o-matic", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
            }
        }
        public void Reset()
        {
            textBox1.Text = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void Pin_Load(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            
        }

        private void txtPin_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            
        }

        private void txtPin_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            textBox1.PasswordChar = 'x';
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
