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
            
            if(int.TryParse(txtUmur.Text, out int age))
            {
                if(int.TryParse(txtBayar.Text, out int bayar))
                {
                   if(bayar < VVIP)
                    {
                        MessageBox.Show("Uang anda Kurang cukup");
                    } 
                   if(int.TryParse(txtBayar.Text, out int kembalian))
                    {
                        if(bayar < VVIP)
                        {
                            kembalian = bayar - VVIP;
                            Console.Write(kembalian);
                        }
                    }
                }
                if (age < 17)
                {
                    MessageBox.Show("Maaf umur anda belum cukup");
                }
            }
        }
    }
}
