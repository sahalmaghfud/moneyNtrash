using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
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

        public static DataTable getAllByDate(string tgl, string bln, string thn)
        {
            DataTable dt = new DataTable();
            MySqlConnection connect = new MySqlConnection(conString);

            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM transaksisampah WHERE tanggal >= @tgl AND tanggal < @nextDay", connect))
            {
                try
                {
                    connect.Open();
                    // Create a valid date string in YYYY-MM-DD format
                    string dateString = thn + "-" + bln.PadLeft(2, '0') + "-" + tgl.PadLeft(2, '0');

                    cmd.Parameters.AddWithValue("@tgl", dateString);

                    // Calculate the next day for inclusive date range (optional, for inclusive search)
                    DateTime selectedDate = DateTime.Parse(dateString);
                    DateTime nextDay = selectedDate.AddDays(1);
                    cmd.Parameters.AddWithValue("@nextDay", nextDay.ToString("yyyy-MM-dd"));

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message); // Log or handle the error appropriately
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }

            return dt;
        }

        public static int deleteTransaksiById(int id)
        {
            int result = 0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("DELETE FROM transaksisampah WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {
                connect.Open();
                adminSampah.updateSaldo("+", getJumlahById(id));
                result = cmd.ExecuteNonQuery();
               

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

        public static double getJumlahById(int id)
        {
            double jumlah = 0.0;
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT total FROM transaksisampah WHERE id = @id");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;

            try
            {             
                connect.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();
                jumlah = dr.GetDouble("total");
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

            return jumlah;
        }
        public static DataTable getLaporanBulanan(string bln, string thn)
        {
            DataTable dt = new DataTable();
            MySqlConnection connect = new MySqlConnection(conString);
            
            string query = "SELECT tanggal,SUM(total)  AS total FROM transaksisampah WHERE MONTH(tanggal) = @bln && YEAR(tanggal) = @thn GROUP BY tanggal";     
            
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connect;
                cmd.Parameters.AddWithValue("@bln", bln);
                cmd.Parameters.AddWithValue("@thn", thn);

                try
                {
                connect.Open() ;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                }
                catch (Exception ex)
                {
                MessageBox.Show("ppp");
                MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            
            return dt;
        }




    }
}
