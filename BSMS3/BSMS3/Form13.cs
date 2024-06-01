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
using BSMS3.BL;
namespace BSMS3
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        internal CustomerDL CustomerDL
        {
            get => default;
            set
            {
            }
        }

        private void Form13_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = CustomerDL.Orders;
            int total = 0;
            foreach(customer c in CustomerDL.Orders)
            {
                total = total + (c.Price * c.Qty);
            }
            txtTotal.Text = total.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy f = new Buy();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllBooks f = new AllBooks();
            f.Show();
        }
    }
}
