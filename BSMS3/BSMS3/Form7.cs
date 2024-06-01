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
    public partial class DeleteItem : Form
    {
        private string path = "Books.txt";
        public DeleteItem()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            BooksGV.DataSource = null;
            BooksGV.DataSource = BooksDL.Booklist;
            BooksGV.Refresh();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //BooksDL.readFromFile(path);
            BooksGV.DataSource = BooksDL.Booklist;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update f = new Update();
            f.Show();
        }

        private void BooksGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BooksBL book = (BooksBL)BooksGV.CurrentRow.DataBoundItem;
            if (BooksGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                BooksDL.deleteBookFromList(book);
                BooksDL.storeAllDatainFile(path);
                dataBind();
            }
            /* else if (BooksGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditForm myform = new EditForm(book);
                myform.ShowDialog();
                BooksDL.storeAllDatainFile(path);
                dataBind();
            }
*/
        }

        private void dltbutton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminAddBook f = new AdminAddBook();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sorting f = new Sorting();
            f.Show();
        }
    }
}
