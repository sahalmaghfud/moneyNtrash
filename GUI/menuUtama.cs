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
    public partial class menuUtama : Form
    {


        private Login? formLogin;
        private sampahSelector? formSelector;
        private setorSampah? formSetor;
        private transaksiLain? formLain;
        private pilihHari? formHarian;
        private pilihBulan? formBulan;

        private bool _loginState = false;
        public bool LoginState
        {
            get => _loginState;
            set
            {
                _loginState = value;
                RefreshData();
            }
        }

        private const int PlastikCode = 101;
        private const int LogamCode = 102;
        private const int KertasCode = 103;
        private const int KacaCode = 104;
        private const int KainCode = 105;
        private const int KaretCode = 106;

        public menuUtama()
        {
            InitializeComponent();
        }

        private void login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formLogin = null;
            RefreshData();
        }

        private void selector_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSelector = null;
        }

        private void setor_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSetor = null;
            RefreshData();
        }

        private void lain_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formLain = null;
            RefreshData();
        }
        private void hari_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formHarian = null;

        }
        private void bulan_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formBulan = null;

        }
        private void menuUtama_Load(object sender, EventArgs e)
        {
            // Load event logic here if needed
        }

        public void loginProses()
        {
            LoginState = true;
            setorSampahToolStripMenuItem.Enabled = true;
            transaksiLainnyaToolStripMenuItem.Enabled = true;
            updateDataToolStripMenuItem.Enabled = true;
            laporanToolStripMenuItem.Enabled = true;
        }

        public void RefreshData()
        {
            if (LoginState)
            {
                plastikBerat.Text = $"{Sampah.getJumlahSampah(PlastikCode)} Kg";
                logamBerat.Text = $"{Sampah.getJumlahSampah(LogamCode)} Kg";
                kertasBerat.Text = $"{Sampah.getJumlahSampah(KertasCode)} Kg";
                kacaBerat.Text = $"{Sampah.getJumlahSampah(KacaCode)} Kg";
                kainBerat.Text = $"{Sampah.getJumlahSampah(KainCode)} Kg";
                karetBerat.Text = $"{Sampah.getJumlahSampah(KaretCode)} Kg";
                saldo.Text = $"Rp. {adminSampah.getSaldo():N0}";
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLogin == null)
            {
                formLogin = new Login(this);
                formLogin.FormClosed += login_FormClosed;
                formLogin.Show();
            }
            else
            {
                formLogin.Activate();
            }
        }


        private void updateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSelector == null)
            {
                formSelector = new sampahSelector();
                formSelector.FormClosed += selector_FormClosed;
                formSelector.Show();
            }
            else
            {
                formSelector.Activate();
            }


        }

        private void setorSampahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSetor == null)
            {
                formSetor = new setorSampah();
                formSetor.FormClosed += setor_FormClosed;
                formSetor.Show();
            }
            else
            {
                formSetor.Activate();
            }
        }

        private void transaksiLainnyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formLain == null)
            {
                formLain = new transaksiLain();
                formLain.FormClosed += lain_FormClosed;
                formLain.Show();
            }
            else
            {
                formLain.Activate();
            }
        }

        private void harianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formHarian == null)
            {
                formHarian = new pilihHari();
                formHarian.FormClosed += hari_FormClosed;
                formHarian.Show();
            }
            else
            {
                formHarian.Activate();
            }
        }

        private void bulananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formBulan == null)
            {
                formBulan = new pilihBulan();
                formBulan.FormClosed += bulan_FormClosed;
                formBulan.Show();
            }
            else
            {
                formBulan.Activate();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}