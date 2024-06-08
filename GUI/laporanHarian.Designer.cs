namespace moneyNtrash.GUI
{
    partial class laporanHarian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            transaksiSampah = new DataGridView();
            idTransaksi = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            waktu = new DataGridViewTextBoxColumn();
            jenis = new DataGridViewTextBoxColumn();
            berat = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            transaksiLain = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            jenisTransaksi = new DataGridViewTextBoxColumn();
            jam = new DataGridViewTextBoxColumn();
            jumlah = new DataGridViewTextBoxColumn();
            deskripsi = new DataGridViewTextBoxColumn();
            label3 = new Label();
            totalSeluruh = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            batalkan = new Button();
            idSmph = new NumericUpDown();
            tanggal = new Label();
            ((System.ComponentModel.ISupportInitialize)transaksiSampah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transaksiLain).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idSmph).BeginInit();
            SuspendLayout();
            // 
            // transaksiSampah
            // 
            transaksiSampah.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transaksiSampah.Columns.AddRange(new DataGridViewColumn[] { idTransaksi, nama, waktu, jenis, berat, Total });
            transaksiSampah.Location = new Point(455, 105);
            transaksiSampah.Name = "transaksiSampah";
            transaksiSampah.ReadOnly = true;
            transaksiSampah.RowHeadersWidth = 30;
            transaksiSampah.Size = new Size(780, 271);
            transaksiSampah.TabIndex = 0;
           
            // 
            // idTransaksi
            // 
            idTransaksi.HeaderText = "ID Transaksi";
            idTransaksi.MinimumWidth = 6;
            idTransaksi.Name = "idTransaksi";
            idTransaksi.ReadOnly = true;
            idTransaksi.Width = 125;
            // 
            // nama
            // 
            nama.HeaderText = "Nama ";
            nama.MinimumWidth = 6;
            nama.Name = "nama";
            nama.ReadOnly = true;
            nama.Width = 125;
            // 
            // waktu
            // 
            waktu.HeaderText = "Waktu";
            waktu.MinimumWidth = 6;
            waktu.Name = "waktu";
            waktu.ReadOnly = true;
            waktu.Width = 125;
            // 
            // jenis
            // 
            jenis.HeaderText = "Jenis Sampah";
            jenis.MinimumWidth = 6;
            jenis.Name = "jenis";
            jenis.ReadOnly = true;
            jenis.Width = 125;
            // 
            // berat
            // 
            berat.HeaderText = "Berat";
            berat.MinimumWidth = 6;
            berat.Name = "berat";
            berat.ReadOnly = true;
            berat.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 476);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 2;
            label1.Text = "Transaksi Lainnya";
          
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 82);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 3;
            label2.Text = "Transaksi Sampah:";
            label2.Click += label2_Click;
            // 
            // transaksiLain
            // 
            transaksiLain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transaksiLain.Columns.AddRange(new DataGridViewColumn[] { id, jenisTransaksi, jam, jumlah, deskripsi });
            transaksiLain.Location = new Point(556, 499);
            transaksiLain.Name = "transaksiLain";
            transaksiLain.ReadOnly = true;
            transaksiLain.RowHeadersWidth = 51;
            transaksiLain.Size = new Size(679, 188);
            transaksiLain.TabIndex = 4;
            // 
            // id
            // 
            id.HeaderText = "ID Transaksi";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // jenisTransaksi
            // 
            jenisTransaksi.HeaderText = "Jenis Transaksi";
            jenisTransaksi.MinimumWidth = 6;
            jenisTransaksi.Name = "jenisTransaksi";
            jenisTransaksi.ReadOnly = true;
            jenisTransaksi.Width = 125;
            // 
            // jam
            // 
            jam.HeaderText = "Waktu";
            jam.MinimumWidth = 6;
            jam.Name = "jam";
            jam.ReadOnly = true;
            jam.Width = 125;
            // 
            // jumlah
            // 
            jumlah.HeaderText = "Jumlah";
            jumlah.MinimumWidth = 6;
            jumlah.Name = "jumlah";
            jumlah.ReadOnly = true;
            jumlah.Width = 125;
            // 
            // deskripsi
            // 
            deskripsi.HeaderText = "Deskripsi";
            deskripsi.MinimumWidth = 6;
            deskripsi.Name = "deskripsi";
            deskripsi.ReadOnly = true;
            deskripsi.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1029, 389);
            label3.Name = "label3";
            label3.Size = new Size(72, 27);
            label3.TabIndex = 5;
            label3.Text = "Total :";
            // 
            // totalSeluruh
            // 
            totalSeluruh.AutoSize = true;
            totalSeluruh.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalSeluruh.Location = new Point(1107, 389);
            totalSeluruh.Name = "totalSeluruh";
            totalSeluruh.Size = new Size(51, 27);
            totalSeluruh.TabIndex = 6;
            totalSeluruh.Text = "XXX";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(batalkan);
            groupBox1.Controls.Add(idSmph);
            groupBox1.Location = new Point(40, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(256, 165);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Batalkan Transaksi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 35);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 9;
            label4.Text = "Masukan ID";
            // 
            // batalkan
            // 
            batalkan.BackColor = Color.IndianRed;
            batalkan.Location = new Point(57, 111);
            batalkan.Name = "batalkan";
            batalkan.Size = new Size(94, 29);
            batalkan.TabIndex = 9;
            batalkan.Text = "Batalkan!";
            batalkan.UseVisualStyleBackColor = false;
            batalkan.Click += batalkan_Click;
            // 
            // idSmph
            // 
            idSmph.Location = new Point(24, 58);
            idSmph.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            idSmph.Name = "idSmph";
            idSmph.Size = new Size(150, 27);
            idSmph.TabIndex = 9;
            // 
            // tanggal
            // 
            tanggal.AutoSize = true;
            tanggal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tanggal.Location = new Point(344, -1);
            tanggal.Name = "tanggal";
            tanggal.Size = new Size(69, 41);
            tanggal.TabIndex = 8;
            tanggal.Text = "xxx";
            // 
            // laporanHarian
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 750);
            Controls.Add(tanggal);
            Controls.Add(groupBox1);
            Controls.Add(totalSeluruh);
            Controls.Add(label3);
            Controls.Add(transaksiLain);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(transaksiSampah);
            Name = "laporanHarian";
            Text = "laporanHarian";
            ((System.ComponentModel.ISupportInitialize)transaksiSampah).EndInit();
            ((System.ComponentModel.ISupportInitialize)transaksiLain).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idSmph).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView transaksiSampah;
        private DataGridViewTextBoxColumn idTransaksi;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn waktu;
        private DataGridViewTextBoxColumn jenis;
        private DataGridViewTextBoxColumn berat;
        private DataGridViewTextBoxColumn Total;
        private Label label1;
        private Label label2;
        private DataGridView transaksiLain;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn jenisTransaksi;
        private DataGridViewTextBoxColumn jam;
        private DataGridViewTextBoxColumn jumlah;
        private DataGridViewTextBoxColumn deskripsi;
        private Label label3;
        private Label totalSeluruh;
        private GroupBox groupBox1;
        private Label tanggal;
        private Label label4;
        private Button batalkan;
        private NumericUpDown idSmph;
    }
}