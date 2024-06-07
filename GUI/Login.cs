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
    public partial class Login : Form
    {

      private menuUtama mainform;
       

        public Login(menuUtama callingForm)
        {
            this.mainform = callingForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(adminSampah.validateLogin(this.textBox1.Text, this.textBox2.Text))
            {
                mainform.loginProses();                
                MessageBox.Show("berhasil");
                this.Close();
            }

        }
    }
}
