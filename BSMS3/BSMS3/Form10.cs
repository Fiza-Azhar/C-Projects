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
using System.IO;
namespace BSMS3
{
    public partial class Buy : Form
    {
        private string Path = "Books.txt";
        public Buy()
        {
            InitializeComponent();
        }

        internal BooksDL BooksDL
        {
            get => default;
            set
            {
            }
        }

        internal CustomerDL CustomerDL
        {
            get => default;
            set
            {
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
        public static BooksBL checkAvailability(string name, int qty)
        {
            foreach (BooksBL book in BooksDL.Booklist)
            {
                if (book.Bname1 == name && book.Stock >= qty)
                {
                    book.Stock = book.Stock - qty;
                    return book;
                }
            }
            return null;
        }
        private void addCartBtn_Click(object sender, EventArgs e)
        {
            string name = txtBname.Text;
            int qty = int.Parse(txtQty.Text);
            if (checkAvailability(name, qty) != null)
            {
                MessageBox.Show("Book is Available");
                customer b = new customer(name, checkAvailability(name, qty).Author , checkAvailability(name, qty).Ctg , qty, checkAvailability(name, qty).Price);
                CustomerDL.AddIntoList(b);
                storeAllDatainFile(Path);
            }
            else
            {
                MessageBox.Show("Book is not Available");
            }
            clear();
            this.Refresh();

        }
        private void clear()
        {
            txtBname.Text = "";
            txtQty.Text = "";
        }
        public static void storeAllDatainFile(string Path)
        {
            StreamWriter file = new StreamWriter(Path);
            foreach (BooksBL book in BooksDL.Booklist)
            {
                file.WriteLine(book.Bname1 + "," + book.Author + "," + book.Ctg + "," + book.Stock + "," + book.Price);
            }
            file.Flush();
            file.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllBooks f = new AllBooks();
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

