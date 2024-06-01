using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSMS3.DL;
namespace BSMS3
{
    public partial class AllBooks : Form
    {
        private string path = "Books.txt";
        public AllBooks()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //BooksDL.readFromFile(path);
            dataGridView1.DataSource = BooksDL.Booklist;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy f = new Buy();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart f = new Cart();
            f.Show();
        }

        private void dltbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill f = new Bill();
            f.Show();
        }
    }
}
