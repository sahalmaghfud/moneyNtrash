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
    public partial class pilihBulan : Form
    {
        public pilihBulan()
        {
            InitializeComponent();
            monthSelector.Format = DateTimePickerFormat.Custom;
            monthSelector.CustomFormat = "MM/yyyy";
            monthSelector.ShowUpDown = true;
        }

        private void pilihButton_Click(object sender, EventArgs e)
        {
            LaporanBulanan formLaporan = new LaporanBulanan(monthSelector.Text);
            formLaporan.Show();
            this.Close();
        }
    }
}
