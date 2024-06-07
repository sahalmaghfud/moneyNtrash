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
    public partial class sampahSelector : Form
    {
        updateData? formUpdate;

       

        public sampahSelector()
        {
            InitializeComponent();
        }

        
        private void pilih_Click(object sender, EventArgs e)
        {
            int idSampah = 0;
            if (selectorr.Text != string.Empty)
            {
                switch (selectorr.Text)
                {
                    case "plastik":
                        idSampah = 101;
                        break;
                    case "logam":
                        idSampah = 102;
                        break;
                    case "kertas":
                        idSampah = 103;
                        break;
                    case "kaca":
                        idSampah = 104;
                        break;
                    case "kain":
                        idSampah = 105;
                        break;
                    case "karet":
                        idSampah = 106;
                        break;
                }
                formUpdate = new updateData(idSampah);
                formUpdate.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("pilih dulu sayang");
            }
        }
    }
}
