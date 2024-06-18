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
using ZstdSharp.Unsafe;

namespace moneyNtrash.GUI
{
    public partial class LaporanBulanan : Form
    {
        private string bln;
       private string  thn;
        public LaporanBulanan(string raw)
        {
          
            InitializeComponent();
            bulan.Text = raw;
            string[] contain = raw.Split('/');
            this.bln = contain[0];
            this.thn = contain[1];
           
            displayLaporanBulananSampah(bln, thn);
            displayLaporanBulananLain(bln, thn);
            decimal totalSampahh = decimal.Parse(totalSampah.Text);
            decimal totalLainn = decimal.Parse(totalLain.Text);

            
            decimal labaa =  totalLainn - totalSampahh;

            
            laba.Text = labaa.ToString();

        }
        private void displayLaporanBulananSampah(string bln, string thn)
        {
           
            DataTable data = TransaksiSampah.getLaporanBulanan(bln, thn); 

            
            dataGridView1.Rows.Clear();
            decimal totalSum = 0;
            
            foreach (DataRow row in data.Rows)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView2);

                
                newRow.Cells[dataGridView2.Columns["tanggalS"].Index].Value = row["tanggal"].ToString();
                decimal temp = Convert.ToDecimal(row["total"]);
                totalSum += temp;
                newRow.Cells[dataGridView2.Columns["totalS"].Index].Value = row["total"].ToString();

               
                dataGridView2.Rows.Add(newRow);
            }
            totalSampah.Text = totalSum.ToString();
           
        }
        private void displayLaporanBulananLain(string bln, string thn)
        {
            
            DataTable data =  trnsksiLain.getLaporanBulanan(bln, thn); 
            
            dataGridView1.Rows.Clear();

            decimal totalSum = 0;

           
            // Iterate through each row in the DataTable
            foreach (DataRow row in data.Rows)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                // Set nilai sel sesuai dengan kolom
                newRow.Cells[dataGridView1.Columns["tanggal"].Index].Value = row["tanggal"].ToString();
                newRow.Cells[dataGridView1.Columns["pemasukan"].Index].Value = row["total_pemasukan"].ToString();
                newRow.Cells[dataGridView1.Columns["pengeluaran"].Index].Value = row["total_pengeluaran"].ToString();

                // Konversi nilai pemasukan dan pengeluaran
                decimal pemasukan = Convert.ToDecimal(row["total_pemasukan"]);
                decimal pengeluaran = Convert.ToDecimal(row["total_pengeluaran"]);
                decimal total = pemasukan - pengeluaran;
                newRow.Cells[dataGridView1.Columns["total"].Index].Value = total.ToString();

                totalSum += total;

                // Add the new row to the DataGridView
                dataGridView1.Rows.Add(newRow);
            }
            totalLain.Text = totalSum.ToString();

            // Optionally, display the total sum somewhere in your form
            // For example:
            // lblTotalSum.Text = totalSum.ToString("C");
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void laba_Click(object sender, EventArgs e)
        {

        }
    }
}
