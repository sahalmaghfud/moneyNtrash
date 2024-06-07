using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace moneyNtrash.kelas
{
    internal class TransaksiSampah
    {
        string nama = string.Empty;
        int idSampah;
        double berat; 
        double total;

        protected const String conString = "server=localhost;database=moneyntrash;uid=root;pwd=;";
        public TransaksiSampah(string nama, int idSampah, double berat, double total) {
            
            this.nama = nama;
            this.idSampah = idSampah;
            this.berat = berat; 
            this.total = total;


        }
        public  int createTransaksi()
        {

            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);//membuat objek untuk koneksi ke mysql
            MySqlCommand cmd = new MySqlCommand("INSERT INTO transaksisampah(id, tanggal,waktu,nama,id_sampah,berat,total) VALUES ('',CURRENT_DATE,CURRENT_TIME,@nama,@idSampah,@berat,@total)");
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@idSampah", idSampah);
            cmd.Parameters.AddWithValue("@berat", berat);
            cmd.Parameters.AddWithValue("@total",total);         
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                result = cmd.ExecuteNonQuery();
                adminSampah.updateSaldo("-", total);
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
