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
    public partial class laporanHarian : Form
    {

        private string tgl;
        private string bln;
        private string thn;
        decimal totalSum;

        public laporanHarian(string tanggalll)
        {
            InitializeComponent();

            tanggal.Text = tanggalll;
            string[] contain = tanggalll.Split('/');
            this.tgl = contain[0];
            this.bln = contain[1];
            this.thn = contain[2];
            totalSum = 0;
            displayTransaksiSampah(this.tgl, this.bln, this.thn);
            totalSeluruh.Text = "Rp." + totalSum.ToString();
            displayTransaksiLain(this.tgl, this.bln, this.thn);



        }

        private void displayTransaksiSampah(string tgl, string bln, string thn)
        {
            DataTable data = TransaksiSampah.getAllByDate(tgl, bln, thn); // Assuming you have this method to retrieve data for a specific day

            // Clear existing data in the DataGridView
            transaksiSampah.Rows.Clear();

            // Iterate through each row in the DataTable
            foreach (DataRow row in data.Rows)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(transaksiSampah);

                newRow.Cells[transaksiSampah.Columns["idTransaksi"].Index].Value = row["id"].ToString(); // Assuming "idTransaksi" is the name of the "id" column
                newRow.Cells[transaksiSampah.Columns["nama"].Index].Value = row["nama"].ToString();
                newRow.Cells[transaksiSampah.Columns["waktu"].Index].Value = row["waktu"].ToString();
                newRow.Cells[transaksiSampah.Columns["jenis"].Index].Value = Sampah.getNameFromId(Convert.ToInt32(row["id_sampah"])); // Use your 'getNamaSampah' method to get the sampah name
                newRow.Cells[transaksiSampah.Columns["berat"].Index].Value = row["berat"].ToString(); // Assuming 'berat' is numeric
                decimal totalValue = Convert.ToDecimal(row["total"]);
                newRow.Cells[transaksiSampah.Columns["Total"].Index].Value = totalValue.ToString();
                totalSum += totalValue;

                // Add the new row to the DataGridView
                transaksiSampah.Rows.Add(newRow);
                transaksiSampah.Show();
            }
        }


        private void displayTransaksiLain(string tgl, string bln, string thn)
        {
            DataTable data = trnsksiLain.getAllByDate(tgl, bln, thn); // Assuming you have this method to retrieve data for a specific day

            // Clear existing data in the DataGridView
            transaksiLain.Rows.Clear();

            // Iterate through each row in the DataTable
            foreach (DataRow row in data.Rows)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(transaksiLain);

                newRow.Cells[transaksiLain.Columns["id"].Index].Value = row["id"].ToString(); // Assuming "id" is the name of the "id" column
                newRow.Cells[transaksiLain.Columns["jenisTransaksi"].Index].Value = row["jenis"].ToString(); // Assuming "jenisTransaksi" is the name of the "jenisTransaksi" column
                newRow.Cells[transaksiLain.Columns["jam"].Index].Value = row["waktu"].ToString(); // Assuming "jam" is the name of the "jam" column
                newRow.Cells[transaksiLain.Columns["jumlah"].Index].Value = row["jumlah"].ToString(); // Assuming "jumlah" is the name of the "jumlah" column
                newRow.Cells[transaksiLain.Columns["deskripsi"].Index].Value = row["deskripsi"].ToString(); // Assuming "deskripsi" is the name of the "deskripsi" column

                // Add the new row to the DataGridView
                transaksiLain.Rows.Add(newRow);
                transaksiLain.Show();
            }
        }





        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void batalkan_Click(object sender, EventArgs e)
        {
            if (idSmph.Value != 0)
            {
                DialogResult result = MessageBox.Show(
                   "Apakah Kamu Yakin Ingin Menghapusnya ?",
                   "Confirmation",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if(idSmph.Value >= 8000)
                    {
                        if (trnsksiLain.deleteById((int)idSmph.Value) == 1)
                        {
                            MessageBox.Show("Berhasil");
                            displayTransaksiLain(this.tgl, this.bln, this.thn);
                        }
                        else
                        {
                            MessageBox.Show("Gagal");
                        }
                    }
                    else
                    {
                        if(TransaksiSampah.deleteTransaksiById((int)idSmph.Value) == 1)
                        {
                            MessageBox.Show("Berhasil");
                            displayTransaksiSampah(this.tgl, this.bln, this.thn);
                            totalSeluruh.Text = "Rp." + totalSum.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Gagal");
                        }
                    }


                }
            }
            
        }
    }
}
