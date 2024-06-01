using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appllication1
{
    public partial class Form4 : Form
    {
        public static string sendtext = "";
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LNames_Click(object sender, EventArgs e)
        {

        }

        private void LStock_Click(object sender, EventArgs e)
        {

        }

        private void LShirt_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string a = Convert.ToString(Convert.ToInt32(shirtP.Text) * Convert.ToInt32(textBox1.Text));
                textBox11.Text = a;
            }
            else
            {
                textBox11.Text = "0";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LSirtT_Click(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void LPrice_Click(object sender, EventArgs e)
        {

        }
        private void NextButton1_Click(object sender, EventArgs e)
        {
            /*sendtext = textBox1.Text;
            Form5 frm = new Form5();
            frm.Show();*/
            Form5 form = new Form5();
            form.text1 = textBox1.Text;
            form.text2 = textBox2.Text;
            form.text3 = textBox3.Text;
            form.text4 = textBox4.Text;
            form.text5 = textBox5.Text;
            form.text11 = textBox11.Text;
            form.text22 = textBox22.Text;
            form.text33 = textBox33.Text;
            form.text44 = textBox44.Text;
            form.text55 = textBox55.Text;
            form.TOTAL = textBoxG.Text;
            form.ShowDialog();
            this.Close();

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "0")
            {
                string a = Convert.ToString(Convert.ToInt32(JeansPrice.Text) * Convert.ToInt32(textBox2.Text));
                textBox22.Text = a;
            }
            else
            {
                textBox22.Text = "0";
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3.Text != "0")
            {
                string a = Convert.ToString(Convert.ToInt32(CapPrice.Text) * Convert.ToInt32(textBox3.Text));
                textBox33.Text = a;
            }
            else
            {
                textBox33.Text = "0";
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox4.Text != "0")
            {
                string a = Convert.ToString(Convert.ToInt32(sockPrice.Text) * Convert.ToInt32(textBox4.Text));
                textBox44.Text = a;
            }
            else
            {
                textBox44.Text = "0";
            }
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox5.Text != "0")
            {
                string a = Convert.ToString(Convert.ToInt32(PantPrice.Text) * Convert.ToInt32(textBox5.Text));
                textBox55.Text = a;
            }
            else
            {
                textBox55.Text = "0";
            }
        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LGrand_Click(object sender, EventArgs e)
        {

        }
       

        private void okButton_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(Convert.ToInt32(textBox11.Text) + Convert.ToInt32(textBox22.Text) + Convert.ToInt32(textBox33.Text) + Convert.ToInt32(textBox44.Text) + Convert.ToInt32(textBox55.Text));
            textBoxG.Text = a;
        }
    }
}
