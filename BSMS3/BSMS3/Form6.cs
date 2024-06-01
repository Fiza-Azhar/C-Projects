using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BSMS3.BL;
using BSMS3.DL;
namespace BSMS3
{
    public partial class Update : Form
    {
        private string path = "Books.txt";
        public Update()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            BooksGV.DataSource = null;
            BooksGV.DataSource = BooksDL.Booklist;
            BooksGV.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewBook f = new AdminViewBook();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddBook f = new AdminAddBook();
            f.Show();
        }

        private void dltbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteItem f = new DeleteItem();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            BooksDL.readFromFile(path);
            BooksGV.DataSource = BooksDL.Booklist;
        }

        private void BooksGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BooksBL book = (BooksBL)BooksGV.CurrentRow.DataBoundItem;
            if (BooksGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditForm myform = new EditForm(book);
                myform.ShowDialog();
                BooksDL.storeAllDatainFile(path);
                dataBind();
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sorting s = new Sorting();
            s.Show();
        }
    }
}
