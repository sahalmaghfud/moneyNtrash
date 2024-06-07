using Google.Protobuf.WellKnownTypes;
using moneyNtrash.kelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneyNtrash.GUI
{
    public partial class setorSampah : Form
    {
        
        public setorSampah()
        {
            InitializeComponent();
        }


        private void nama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents the beep sound
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void hitung_Click(object sender, EventArgs e)
        {        
          
            double hrg = Sampah.getHarga(cekid());
            double jmh = hrg * (double)berat.Value;
            tombolSImpan.Enabled = true;
            harga.Text = "Rp" + hrg.ToString();
            jumlahbox.Text = jmh.ToString();

        }
        private int cekid()
        {
            int idSampah = 0;
            string jenisBarang = jenis.Text;
            switch (jenisBarang)
            {
                case "plastik":
                    idSampah = 101;
                    break;
                case "logam":
                    idSampah = 102;
                    break;
                case "kertas":
                    idSampah = 103;
                    break;
                case "kaca":
                    idSampah = 104;
                    break;
                case "kain":
                    idSampah = 105;
                    break;
                case "karet":
                    idSampah = 106;
                    break;


            }
            return idSampah;

        }

        private void tombolSImpan_Click(object sender, EventArgs e)
        {
          if(nama.Text != string.Empty && berat.Value != 0) {
                double jumlah = Convert.ToDouble(jumlahbox.Text);
                TransaksiSampah transaksi = new TransaksiSampah(nama.Text, cekid(), (double)berat.Value,jumlah);
                if(transaksi.createTransaksi() == 1)
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
