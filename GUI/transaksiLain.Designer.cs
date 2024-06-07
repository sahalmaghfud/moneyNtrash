namespace moneyNtrash.GUI
{
    partial class transaksiLain
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
            label1 = new Label();
            jenisTransaksi = new ComboBox();
            jumlah = new NumericUpDown();
            simpan = new Button();
            catatan = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)jumlah).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 39);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Jenis Transaksi";
            // 
            // jenisTransaksi
            // 
            jenisTransaksi.DropDownStyle = ComboBoxStyle.DropDownList;
            jenisTransaksi.FormattingEnabled = true;
            jenisTransaksi.Items.AddRange(new object[] { "pemasukan", "pengeluaran" });
            jenisTransaksi.Location = new Point(41, 62);
            jenisTransaksi.Name = "jenisTransaksi";
            jenisTransaksi.Size = new Size(151, 28);
            jenisTransaksi.TabIndex = 1;
            // 
            // jumlah
            // 
            jumlah.Location = new Point(42, 140);
            jumlah.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            jumlah.Name = "jumlah";
            jumlah.Size = new Size(150, 27);
            jumlah.TabIndex = 2;
            // 
            // simpan
            // 
            simpan.BackColor = Color.GreenYellow;
            simpan.Location = new Point(98, 367);
            simpan.Name = "simpan";
            simpan.Size = new Size(94, 29);
            simpan.TabIndex = 3;
            simpan.Text = "Simpan";
            simpan.UseVisualStyleBackColor = false;
            simpan.Click += simpan_Click;
            // 
            // catatan
            // 
            catatan.Location = new Point(39, 218);
            catatan.MaxLength = 200;
            catatan.Name = "catatan";
            catatan.Size = new Size(271, 120);
            catatan.TabIndex = 4;
            catatan.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 195);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 5;
            label2.Text = "Catatan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 117);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Jumlah (Rp)";
            // 
            // transaksiLain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(catatan);
            Controls.Add(simpan);
            Controls.Add(jumlah);
            Controls.Add(jenisTransaksi);
            Controls.Add(label1);
            Name = "transaksiLain";
            Text = "transaksi lainnya";
            ((System.ComponentModel.ISupportInitialize)jumlah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox jenisTransaksi;
        private NumericUpDown jumlah;
        private Button simpan;
        private RichTextBox catatan;
        private Label label2;
        private Label label3;
    }
}