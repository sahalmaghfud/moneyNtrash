using moneyNtrash.kelas;
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
    public partial class updateData : Form
    {
        int idSampah = 0;
        

        public updateData(int idSampah)
        {
            this.idSampah = idSampah;
            InitializeComponent();

           
            harga.Value = (decimal)Sampah.getHarga(idSampah);
            stok.Value = (decimal)Sampah.getJumlahSampah(idSampah);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
           if( Sampah.updateSampah(this.idSampah,(double)harga.Value,(double)stok.Value) == 1)
            {
                MessageBox.Show("berhasil");
                this.Close();
            }
            else
            {
                MessageBox.Show("ada yang salah nich?");
            }

        }
    }
}
