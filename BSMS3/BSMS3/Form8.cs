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
    public partial class EditForm : Form
    {
        private BooksBL previous;
        public EditForm(BooksBL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        public Update Update
        {
            get => default;
            set
            {
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            BooksBL updated = new BooksBL(txtname.Text, txtathr.Text, comboBox1.Text, int.Parse(txtstock.Text), int.Parse(txtprice.Text));
            BooksDL.EditBookFromList(previous, updated);
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            txtname.Text = previous.Bname1;
            txtathr.Text = previous.Author;
            comboBox1.Text = previous.Ctg;
            txtstock.Text = Convert.ToString(previous.Stock);
            txtprice.Text = Convert.ToString(previous.Price);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
