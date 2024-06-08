namespace moneyNtrash.GUI
{
    partial class LaporanBulanan
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
            bulan = new Label();
            label1 = new Label();
            laba = new Label();
            dataGridView2 = new DataGridView();
            tanggalS = new DataGridViewTextBoxColumn();
            totalS = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            totalLain = new Label();
            totalSampah = new Label();
            dataGridView1 = new DataGridView();
            tanggal = new DataGridViewTextBoxColumn();
            pemasukan = new DataGridViewTextBoxColumn();
            pengeluaran = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // bulan
            // 
            bulan.AutoSize = true;
            bulan.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bulan.Location = new Point(361, 2);
            bulan.Name = "bulan";
            bulan.Size = new Size(59, 37);
            bulan.TabIndex = 1;
            bulan.Text = "xxx";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label1.Location = new Point(-1, 564);
            label1.Name = "label1";
            label1.Size = new Size(175, 38);
            label1.TabIndex = 2;
            label1.Text = "TOTAL LABA";
            label1.Click += label1_Click;
            // 
            // laba
            // 
            laba.AutoSize = true;
            laba.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            laba.Location = new Point(210, 564);
            laba.Name = "laba";
            laba.Size = new Size(59, 38);
            laba.TabIndex = 3;
            laba.Text = "xxx";
            laba.Click += laba_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { tanggalS, totalS });
            dataGridView2.Location = new Point(679, 64);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(311, 303);
            dataGridView2.TabIndex = 4;
            // 
            // tanggalS
            // 
            tanggalS.HeaderText = "Tanggal";
            tanggalS.MinimumWidth = 6;
            tanggalS.Name = "tanggalS";
            tanggalS.Width = 125;
            // 
            // totalS
            // 
            totalS.HeaderText = "Total Pengeluaran";
            totalS.MinimumWidth = 6;
            totalS.Name = "totalS";
            totalS.ReadOnly = true;
            totalS.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 5;
            label2.Text = "Transaksi Lain:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(679, 41);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 6;
            label3.Text = "Setoran Sampah ";
            // 
            // totalLain
            // 
            totalLain.AutoSize = true;
            totalLain.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            totalLain.Location = new Point(483, 379);
            totalLain.Name = "totalLain";
            totalLain.Size = new Size(59, 38);
            totalLain.TabIndex = 8;
            totalLain.Text = "xxx";
            // 
            // totalSampah
            // 
            totalSampah.AutoSize = true;
            totalSampah.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            totalSampah.Location = new Point(890, 388);
            totalSampah.Name = "totalSampah";
            totalSampah.Size = new Size(59, 38);
            totalSampah.TabIndex = 10;
            totalSampah.Text = "xxx";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tanggal, pemasukan, pengeluaran, total });
            dataGridView1.Location = new Point(12, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(530, 294);
            dataGridView1.TabIndex = 11;
            // 
            // tanggal
            // 
            tanggal.HeaderText = "Tanggal";
            tanggal.MinimumWidth = 6;
            tanggal.Name = "tanggal";
            tanggal.Width = 125;
            // 
            // pemasukan
            // 
            pemasukan.HeaderText = "Pemasukan";
            pemasukan.MinimumWidth = 6;
            pemasukan.Name = "pemasukan";
            pemasukan.Width = 125;
            // 
            // pengeluaran
            // 
            pengeluaran.HeaderText = "Pengeluaran";
            pengeluaran.MinimumWidth = 6;
            pengeluaran.Name = "pengeluaran";
            pengeluaran.Width = 125;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 125;
            // 
            // LaporanBulanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 611);
            Controls.Add(dataGridView1);
            Controls.Add(totalSampah);
            Controls.Add(totalLain);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(laba);
            Controls.Add(label1);
            Controls.Add(bulan);
            Name = "LaporanBulanan";
            Text = "LaporanBulanan";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label bulan;
        private Label label1;
        private Label laba;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn tanggalS;
        private DataGridViewTextBoxColumn totalS;
        private Label label2;
        private Label label3;
        private Label totalLain;
        private Label totalSampah;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridViewTextBoxColumn pemasukan;
        private DataGridViewTextBoxColumn pengeluaran;
        private DataGridViewTextBoxColumn total;
    }
}