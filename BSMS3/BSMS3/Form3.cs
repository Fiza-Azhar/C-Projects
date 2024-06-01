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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void clearFormData()
        {
            txtNameUp.Text = "";
            txtPassUp.Text = "";
            comboBox1.Text = "";
        }


        private void backBtn1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn f = new LogIn();
            f.Show();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            
            if (txtNameUp.Text != null && txtPassUp.Text != null && comboBox1 != null)
            {
                string userName = txtNameUp.Text;
                string userPass = txtPassUp.Text;
                string userRole = comboBox1.Text;
                string path = "users.txt";
                Muser user = new Muser(userName, userPass, userRole);
                MuserDL.AddIntoList(user);
                MuserDL.storeUserIntoFile(user, path);
                MessageBox.Show("user added");
                clearFormData();
                if(userRole == "Admin")
                {
                    this.Hide();
                    AdminAddBook f = new AdminAddBook();
                    f.Show();
                }
                else
                {
                    this.Hide();
                    AdminViewBook f = new AdminViewBook();
                    f.Show();
                }
            }
            else if(txtNameUp.Text == null || txtPassUp.Text == null || comboBox1 == null)
            {
                MessageBox.Show("Please enter information");
            }
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txtNameUp.Text = "";
            txtPassUp.Text = "";
            comboBox1.Text = "";
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
