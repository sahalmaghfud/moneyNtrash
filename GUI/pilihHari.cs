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
    public partial class pilihHari : Form
    {
        public pilihHari()
        {
            InitializeComponent();
            daySelector.Format = DateTimePickerFormat.Custom;
            daySelector.CustomFormat = "dd/MM/yyyy";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            laporanHarian formLaporan = new laporanHarian(daySelector.Text);
            formLaporan.Show();
            this.Close();
            
        }
    }
}
