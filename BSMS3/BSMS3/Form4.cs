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
    public partial class AdminAddBook : Form
    {
        public AdminAddBook()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminViewBook form = new AdminViewBook();
            form.Show();

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if(txtname.Text != null || txtathr.Text != null || txtstock.Text != null || txtprice.Text != null || comboBox1.Text != null)
            {
                string name = txtname.Text;
                string author = txtathr.Text;
                string ctg = comboBox1.Text;
                int stock = int.Parse(txtstock.Text);
                int price = int.Parse(txtprice.Text);
                BooksBL book = new BooksBL(name, author, ctg, stock, price);
                BooksDL.AddIntoBooksList(book);
                BooksDL.storeIntoFile(book, "Books.txt");
            }
            else
            {
                MessageBox.Show("Please enter complete information");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update f = new Update();
            f.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dltbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteItem f = new DeleteItem();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
