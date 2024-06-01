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
    public partial class AdminViewBook : Form
    {
        private string path = "Books.txt";
        public AdminViewBook()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            /*this.Refresh();
            BooksDL.readFromFile(path);*/
            dataGridView1.DataSource = BooksDL.Booklist;
        }
        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = BooksDL.Booklist;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddBook f = new AdminAddBook();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update f = new Update();
            f.Show();
        }

        private void dltbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteItem f = new DeleteItem();
            f.Show();
        }
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sorting s = new Sorting();
            s.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
