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
    public partial class Form5 : Form
    {
        public string text1 { get; set; }
        public string text2 { get; set; }
        public string text3 { get; set; }
        public string text4 { get; set; }
        public string text5 { get; set; }
        public string text11 { get; set; }
        public string text22 { get; set; }
        public string text33 { get; set; }
        public string text44 { get; set; }
        public string text55 { get; set; }
        public string TOTAL { get; set; }

        //public static string textPassedForm5;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SHIRTQ.Text = text1;
            JEANSQ.Text = text2;
            label2.Text = text3;
            SOCKQ.Text = text4;
            PANTQ.Text = text5;
            shirtt.Text = text11;
            jeanst.Text = text22;
            capt.Text = text33;
            sockt.Text = text44;
            Pantt.Text = text55;
            total.Text = TOTAL;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
