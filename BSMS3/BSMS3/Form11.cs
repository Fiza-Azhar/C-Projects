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
    public partial class Cart : Form
    {
        public Cart()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            //CustomerDL.readFromOrderFile(path);
            dataGridView1.DataSource = CustomerDL.Orders;
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

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dltbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bill f = new Bill();
            f.Show();
        }
    }
}
