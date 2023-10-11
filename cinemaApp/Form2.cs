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
    public partial class RegisPage : Form
    {
        public RegisPage()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(txtFirstname.Text == string.Empty || txtLastname.Text == string.Empty || txtUserRegis.Text == string.Empty || txtPassRegis.Text == string.Empty)
            {
                MessageBox.Show("Isi data dengan Lengkap");
            } else
            {
                table.Rows.Add(txtFirstname.Text, txtLastname.Text, txtUserRegis.Text, txtPassRegis.Text);
                dataGridView1.DataSource = table;
            }
        }
        DataTable table = new DataTable();

        private void btnNext_Click(object sender, EventArgs e)
        {
            HomePage f2 = new HomePage();
            f2.Show();
            this.Hide();
                     
        }

        private void RegisPage_Load(object sender, EventArgs e)
        {
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));

            dataGridView1.DataSource = table;
        }
    }
}
