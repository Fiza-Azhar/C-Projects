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
    public partial class LogIn : Form
    {
        //private string path = "Books.txt";
       
        public LogIn()
        {
            InitializeComponent();
             string BooksPath = "Books.txt";
             BooksDL.readFromFile(BooksPath);
            string path = "users.txt";
            MuserDL.readDataFromFile(path);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignIn f = new SignIn();
            f.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp f = new SignUp();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
