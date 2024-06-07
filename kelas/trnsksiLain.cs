using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneyNtrash.kelas
{
    internal class trnsksiLain
    {
        string catatan = string.Empty;
        string jenis = string.Empty;
        double jumlah;

        protected const String conString = "server=localhost;database=moneyntrash;uid=root;pwd=;";
        public trnsksiLain(double jumlah, string jenis, string catatan)
        {

            this.jumlah = jumlah;
            this.jenis = jenis;            
            this.catatan = catatan;


        }
        public int createTransaksi()
        {

            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);//membuat objek untuk koneksi ke mysql
            MySqlCommand cmd = new MySqlCommand("INSERT INTO transaksi_lain(id,jenis, tanggal,waktu,jumlah,deskripsi) VALUES ('',@jenis,CURRENT_DATE,CURRENT_TIME,@jumlah,@catatan)");
            cmd.Parameters.AddWithValue("@jenis",this.jenis);
            cmd.Parameters.AddWithValue("@jumlah", this.jumlah);
            cmd.Parameters.AddWithValue("@catatan",this.catatan);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
                if (jenis == "pengeluaran")
                {
                    adminSampah.updateSaldo("-", jumlah);
                }
                else
                {
                    adminSampah.updateSaldo("+", jumlah);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return result;
        }

    }
}

