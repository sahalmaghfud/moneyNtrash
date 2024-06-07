using moneyNtrash.kelas;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyNtrash.GUI
{
    public partial class transaksiLain : Form
    {
        public transaksiLain()
        {
            InitializeComponent();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if (jenisTransaksi.Text != string.Empty && jumlah.Value != 0 && catatan.Text != string.Empty)
            {

                trnsksiLain transaksi = new trnsksiLain((double)jumlah.Value,jenisTransaksi.Text,catatan.Text);
                if (transaksi.createTransaksi() == 1)
                {
                    MessageBox.Show("behasil");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("gagal");
                }
            }
            else
            {
                MessageBox.Show("isi yang bener ya sayang");
            }
        }
    }
}
