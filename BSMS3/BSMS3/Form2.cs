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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void clearFormData()
        {
            txtName.Text = "";
            txtPass.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Pass = txtPass.Text;
            Muser user = new Muser(Name, Pass);
            Muser valid = MuserDL.signIn(user);
            if (valid != null)
            {
                MessageBox.Show("valid user");
                if (valid.UserRole == "Admin" || valid.UserRole == "admin")
                {
                    this.Hide();
                    AdminAddBook form = new AdminAddBook();
                    form.Show();
                }
                else
                {
                    this.Hide();
                    CustMenu form = new CustMenu();
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("not valid user");
            }
            clearFormData();
        }

        private void resetBtn_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPass.Text = "";
        }

        private void backBtn1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn f = new LogIn();
            f.Show();
        }
    }
}
