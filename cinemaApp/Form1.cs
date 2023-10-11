using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaApp
{
    public partial class LoginPage : Form
    {
        readonly string Username = "admin";
        readonly string Password = "1245";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Username && txtPassword.Text == Password)
            {
                HomePage f2 = new HomePage();
                f2.Show();
                this.Hide();
            } else if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Isi dengan Lengkap");
            } else
            {
                MessageBox.Show("Username/Password salah");
            }
               
        }

        private void txtRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisPage f2 = new RegisPage();
            f2.Show();
            this.Hide();
        }
    }
}
