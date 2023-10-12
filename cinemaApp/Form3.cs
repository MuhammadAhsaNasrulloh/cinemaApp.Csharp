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
    public partial class HomePage : Form
    {
   
        readonly int VVIP = 10000;
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int kembalian;
string tiket = comboBox1.Text;
string film = comboBox2.Text;

if (int.TryParse(txtUmur.Text, out int age))
{
    if (age <= 16)
    {
        MessageBox.Show("Maaf umur anda kurang cukup");
    }

    if (string.IsNullOrEmpty(tiket))
    {
        MessageBox.Show("Tiket belum dipilih.");
    }
    if(string.IsNullOrEmpty(film))
    {
        MessageBox.Show("Maaf film yang anda pilih tidak ada");
    }
    else
    {
        if (int.TryParse(txtBayar.Text, out int bayar))
        {
            if (tiket == "VVIP")
            {
                if (bayar >= VVIP)
                {
                    kembalian = bayar - VVIP;
                    MessageBox.Show("Nama: " + txtNamaTiket.Text + "\nUmur :" + txtUmur.Text + "\nKembalian: " + kembalian.ToString() + "\nBayar :" + txtBayar.Text + "\nTiket :" + comboBox1.Text);
                }
                else if (bayar < VVIP)
                {
                    MessageBox.Show("Maaf uang anda kurang");
                }
            }
            else if(tiket == "VIP")
            {
                if (bayar >= VIP)
                {
                    kembalian = bayar - VIP;
                    MessageBox.Show("Nama: " + txtNamaTiket.Text + "\nUmur :" + txtUmur.Text + "\nKembalian: " + kembalian.ToString() + "\nBayar :"+ txtBayar.Text +"\nTiket :" + comboBox1.Text);
                } else if (bayar < VIP)
                {
                    MessageBox.Show("Maaf uang anda kurang");
                }
            }
            else if (tiket == "Reguler")
            {
                if (bayar >= Reguler)
                {
                    kembalian = bayar - Reguler;
                    MessageBox.Show("Nama: " + txtNamaTiket.Text + "\nUmur :" + txtUmur.Text + "\nKembalian: " + kembalian.ToString() + "\nBayar :" + txtBayar.Text + "\nTiket :" + comboBox1.Text);
                }
                else if (bayar < Reguler)
                {
                    MessageBox.Show("Maaf uang anda kurang");
                }
            }
        }
    }
           
    
        }
    }
}
