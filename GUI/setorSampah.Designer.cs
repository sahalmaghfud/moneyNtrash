namespace moneyNtrash.GUI
{
    partial class setorSampah
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
            nama = new TextBox();
            berat = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            jenis = new ComboBox();
            label3 = new Label();
            tombolSImpan = new Button();
            groupBox1 = new GroupBox();
            jumlahbox = new TextBox();
            jumlah = new Label();
            hitung = new Button();
            harga = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)berat).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nama
            // 
            nama.Location = new Point(18, 57);
            nama.Name = "nama";
            nama.Size = new Size(216, 27);
            nama.TabIndex = 0;
            nama.KeyDown += nama_KeyDown;
            // 
            // berat
            // 
            berat.Location = new Point(18, 195);
            berat.Name = "berat";
            berat.Size = new Size(150, 27);
            berat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Nama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 172);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "Berat :";
            // 
            // jenis
            // 
            jenis.DropDownStyle = ComboBoxStyle.DropDownList;
            jenis.FormattingEnabled = true;
            jenis.Items.AddRange(new object[] { "plastik", "logam", "kertas", "kaca", "kain", "karet" });
            jenis.Location = new Point(18, 132);
            jenis.Name = "jenis";
            jenis.Size = new Size(151, 28);
            jenis.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 99);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "Jenis :";
            // 
            // tombolSImpan
            // 
            tombolSImpan.BackColor = Color.GreenYellow;
            tombolSImpan.Enabled = false;
            tombolSImpan.Location = new Point(146, 353);
            tombolSImpan.Name = "tombolSImpan";
            tombolSImpan.Size = new Size(94, 29);
            tombolSImpan.TabIndex = 8;
            tombolSImpan.Text = "Simpan";
            tombolSImpan.UseVisualStyleBackColor = false;
            tombolSImpan.Click += tombolSImpan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nama);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(jenis);
            groupBox1.Controls.Add(berat);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(26, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 244);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA";
            // 
            // jumlahbox
            // 
            jumlahbox.Enabled = false;
            jumlahbox.Location = new Point(44, 320);
            jumlahbox.Name = "jumlahbox";
            jumlahbox.Size = new Size(196, 27);
            jumlahbox.TabIndex = 10;
            // 
            // jumlah
            // 
            jumlah.AutoSize = true;
            jumlah.Location = new Point(45, 297);
            jumlah.Name = "jumlah";
            jumlah.Size = new Size(87, 20);
            jumlah.TabIndex = 11;
            jumlah.Text = "Jumlah (Rp)";
            // 
            // hitung
            // 
            hitung.BackColor = Color.RosyBrown;
            hitung.Location = new Point(276, 299);
            hitung.Name = "hitung";
            hitung.Size = new Size(94, 29);
            hitung.TabIndex = 12;
            hitung.Text = "Hitung";
            hitung.UseVisualStyleBackColor = false;
            hitung.Click += hitung_Click;
            // 
            // harga
            // 
            harga.AutoSize = true;
            harga.Location = new Point(110, 276);
            harga.Name = "harga";
            harga.Size = new Size(0, 20);
            harga.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 277);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 14;
            label4.Text = "Harga = ";
            // 
            // setorSampah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 453);
            Controls.Add(label4);
            Controls.Add(harga);
            Controls.Add(hitung);
            Controls.Add(jumlah);
            Controls.Add(jumlahbox);
            Controls.Add(groupBox1);
            Controls.Add(tombolSImpan);
            Name = "setorSampah";
            Text = "setorSampah";
            ((System.ComponentModel.ISupportInitialize)berat).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nama;
        private NumericUpDown berat;
        private Label label1;
        private Label label2;
        private ComboBox jenis;
        private Label label3;
        private Button tombolSImpan;
        private GroupBox groupBox1;
        private TextBox jumlahbox;
        private Label jumlah;
        private Button hitung;
        private Label harga;
        private Label label4;
    }
}