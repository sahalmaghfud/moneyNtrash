using moneyNtrash.GUI;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

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
            cmd.Parameters.AddWithValue("@jenis", this.jenis);
            cmd.Parameters.AddWithValue("@jumlah", this.jumlah);
            cmd.Parameters.AddWithValue("@catatan", this.catatan);
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

        public static DataTable getAllByDate(string tgl, string bln, string thn)
        {
            DataTable dt = new DataTable();
            MySqlConnection connect = new MySqlConnection(conString);
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM transaksi_lain WHERE tanggal >= @tgl AND tanggal < @nextDay", connect))
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
                return dt;
            }


        }
        public static int deleteById(int id)
        {
            int result = 0;
            string query = "DELETE FROM transaksi_lain WHERE id = @id";

            using (MySqlConnection connect = new MySqlConnection(conString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    connect.Open();

                    if (getJenisById(id) == "pemasukan")
                    {
                        adminSampah.updateSaldo("-", getJumlahById(id));
                    }
                    else
                    {
                        adminSampah.updateSaldo("+", getJumlahById(id));
                    }
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
            }
            return result;
        }

        public static string getJenisById(int id)
        {
            string jenis = string.Empty;
            string query = "SELECT jenis FROM transaksi_lain WHERE id = @id";

            using (MySqlConnection connect = new MySqlConnection(conString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    connect.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {

                        dr.Read();
                        jenis = dr.GetString("jenis");

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
            }
            return jenis ?? string.Empty;
        }

        public static int getJumlahById(int id)
        {
            int jumlah = 0;
            string query = "SELECT jumlah FROM transaksi_lain WHERE id = @id";

            using (MySqlConnection connect = new MySqlConnection(conString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    connect.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            jumlah = Convert.ToInt32(reader["jumlah"]);
                        }
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
            }
            return jumlah;
        }

        public static DataTable getLaporanBulanan(string bln, string thn)
        {
            DataTable dt = new DataTable();
            string query = @"SELECT
    dates.tanggal,
            COALESCE(pemasukan.total, 0) AS total_pemasukan,
            COALESCE(pengeluaran.total, 0) AS total_pengeluaran
FROM
            (SELECT DISTINCT tanggal FROM transaksi_lain) AS dates
LEFT JOIN
            (SELECT tanggal, SUM(jumlah) AS total FROM transaksi_lain WHERE jenis = 'pemasukan' GROUP BY tanggal) AS pemasukan
ON
    dates.tanggal = pemasukan.tanggal
LEFT JOIN
    (SELECT tanggal, SUM(jumlah) AS total FROM transaksi_lain WHERE jenis = 'pengeluaran' GROUP BY tanggal) AS pengeluaran
ON
    dates.tanggal = pengeluaran.tanggal
WHERE
    MONTH(dates.tanggal) = @bln
    AND YEAR(dates.tanggal) = @thn
ORDER BY
    dates.tanggal;
            ";

            using (MySqlConnection connect = new MySqlConnection(conString))
            {
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@bln", bln);
                cmd.Parameters.AddWithValue("@thn",thn);

                try
                {
                    connect.Open() ;
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
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
            }
            return dt;
            }
        }
    }

    

