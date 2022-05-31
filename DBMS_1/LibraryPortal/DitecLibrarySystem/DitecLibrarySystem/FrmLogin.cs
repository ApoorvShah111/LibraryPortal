using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DitecLibrarySystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "0000")
            {
                FrmHome h = new FrmHome();
                h.adminUser = true;
                h.Show();
                this.Hide();
            }
            else if (txtUserName.Text == "member" && txtPassword.Text == "1111")
            {
                FrmHome h = new FrmHome();
                h.Show();
                this.Hide();
            }
            else if (txtUserName.Text == "Apoorv" && txtPassword.Text == "godcomplex")
            {
                FrmHome h = new FrmHome();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong with your username or password !",
                    "Sign In Fail !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
