using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace moneyNtrash.kelas
{
    internal class Sampah
    {

       

        public Sampah()
        {
           
        }

        protected const String conString = "server=localhost;database=moneyntrash;uid=root;pwd=;";
        //method getUser: method untuk mengecek apakah usr dan pwd tertentu ada di tabel users
        //apabila usr dan pwd ditemukan, maka method getUser akan mengembalikan nilai boolean true;
        public static double getJumlahSampah(int id)
        {
            double result = 0;
            MySqlConnection connect = new MySqlConnection(conString);//membuat objek untuk koneksi ke mysql
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM datasampah WHERE id = @id;", connect);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            //cmd.Connection = connect;
            try
            {
                connect.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    result = dr.GetDouble("jumlahtersimpan");
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

        public static double getHarga(int id)
        {

            double result = 0;
            MySqlConnection connect = new MySqlConnection(conString);//membuat objek untuk koneksi ke mysql
            MySqlCommand cmd = new MySqlCommand("SELECT harga FROM datasampah WHERE id = @id;", connect);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandType = CommandType.Text;
            //cmd.Connection = connect;
            try
            {
                connect.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    result = dr.GetDouble("harga");
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

        public static int updateSampah(int idSampah, double harga, double stok)
        {
            int rst = 0;
           
            MySqlConnection connect = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("UPDATE datasampah SET harga = @harga , jumlahTersimpan=@stok WHERE id = @idSampah");
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@stok", stok);
            cmd.Parameters.AddWithValue("@idSampah",idSampah);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
              connect.Open();
             rst= cmd.ExecuteNonQuery();
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
            return rst;
        }

        public static string getNameFromId(int id)
        {
            string namaSampah;

            switch (id)
            {
                case 101:
                    namaSampah = "plastik";
                    break;
                case 102:
                    namaSampah = "logam";
                    break;
                case 103:
                    namaSampah = "kertas";
                    break;
                case 104:
                    namaSampah = "kaca";
                    break;
                case 105:
                    namaSampah = "kain";
                    break;
                case 106:
                    namaSampah = "karet";
                    break;
                default:
                    namaSampah = "Unknown";
                    break;
            }
            return namaSampah;
            

        }


    }
}
