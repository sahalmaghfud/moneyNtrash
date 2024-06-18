using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneyNtrash.kelas
{
    internal class adminSampah
    {
             protected const String conString = "server=localhost;database=moneyntrash;uid=root;pwd=;";
     
        //method getUser: method untuk mengecek apakah usr dan pwd tertentu ada di tabel users
        //apabila usr dan pwd ditemukan, maka method getUser akan mengembalikan nilai boolean true;
        public static double getSaldo()
        {
            double result = 0;
            MySqlConnection connect = new MySqlConnection(conString);//membuat objek untuk koneksi ke mysql
            MySqlCommand cmd = new MySqlCommand("SELECT saldo FROM admin;", connect);
            cmd.CommandType = CommandType.Text;
            try
            {
                connect.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();  
                dr.Read();
                result = dr.GetDouble("saldo");
                
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

        public static void  updateSaldo(string tanda, double jumlah)
        {
            if(tanda == "+" || tanda == "-") 
            { 

            MySqlConnection connect = new MySqlConnection(conString);//membuat objek untuk koneksi ke mysql
            MySqlCommand cmd = new MySqlCommand("UPDATE admin SET saldo = saldo - @jumlah WHERE username = 'admin';");
                if (tanda == "+")
                {
                     cmd = new MySqlCommand("UPDATE admin SET saldo = saldo + @jumlah WHERE username = 'admin';");
                }           
            cmd.Parameters.AddWithValue("@tanda", tanda);
            cmd.Parameters.AddWithValue("@jumlah", jumlah);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();
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

        }

        public static bool validateLogin(string username, string password)
        {
            bool result = false;
            MySqlConnection connect = new MySqlConnection(conString);//membuat objek untuk koneksi ke mys
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM admin WHERE username = @user && password = @pwd", connect);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pwd",password);
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.Text;
            try
            {
                connect.Open();
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
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
       