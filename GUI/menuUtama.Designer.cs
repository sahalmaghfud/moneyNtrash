namespace moneyNtrash.GUI
{
    partial class menuUtama
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            setorSampahToolStripMenuItem = new ToolStripMenuItem();
            transaksiLainnyaToolStripMenuItem = new ToolStripMenuItem();
            updateDataToolStripMenuItem = new ToolStripMenuItem();
            laporanToolStripMenuItem = new ToolStripMenuItem();
            harianToolStripMenuItem = new ToolStripMenuItem();
            bulananToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            status = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            label1 = new Label();
            saldo = new Label();
            label3 = new Label();
            kacaBerat = new Label();
            kertasBerat = new Label();
            logamBerat = new Label();
            plastikBerat = new Label();
            kainBerat = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            pictureBox8 = new PictureBox();
            karetBerat = new Label();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, setorSampahToolStripMenuItem, transaksiLainnyaToolStripMenuItem, updateDataToolStripMenuItem, laporanToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1296, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(60, 24);
            loginToolStripMenuItem.Text = "&Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // setorSampahToolStripMenuItem
            // 
            setorSampahToolStripMenuItem.Enabled = false;
            setorSampahToolStripMenuItem.Name = "setorSampahToolStripMenuItem";
            setorSampahToolStripMenuItem.Size = new Size(116, 24);
            setorSampahToolStripMenuItem.Text = "&Setor Sampah";
            setorSampahToolStripMenuItem.Click += setorSampahToolStripMenuItem_Click;
            // 
            // transaksiLainnyaToolStripMenuItem
            // 
            transaksiLainnyaToolStripMenuItem.Enabled = false;
            transaksiLainnyaToolStripMenuItem.Name = "transaksiLainnyaToolStripMenuItem";
            transaksiLainnyaToolStripMenuItem.Size = new Size(136, 24);
            transaksiLainnyaToolStripMenuItem.Text = "&Transaksi Lainnya";
            transaksiLainnyaToolStripMenuItem.Click += transaksiLainnyaToolStripMenuItem_Click;
            // 
            // updateDataToolStripMenuItem
            // 
            updateDataToolStripMenuItem.Enabled = false;
            updateDataToolStripMenuItem.Name = "updateDataToolStripMenuItem";
            updateDataToolStripMenuItem.Size = new Size(108, 24);
            updateDataToolStripMenuItem.Text = "&Update Data";
            updateDataToolStripMenuItem.Click += updateDataToolStripMenuItem_Click;
            // 
            // laporanToolStripMenuItem
            // 
            laporanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { harianToolStripMenuItem, bulananToolStripMenuItem });
            laporanToolStripMenuItem.Enabled = false;
            laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            laporanToolStripMenuItem.Size = new Size(77, 24);
            laporanToolStripMenuItem.Text = "&Laporan";
            // 
            // harianToolStripMenuItem
            // 
            harianToolStripMenuItem.Name = "harianToolStripMenuItem";
            harianToolStripMenuItem.Size = new Size(224, 26);
            harianToolStripMenuItem.Text = "Harian ";
            harianToolStripMenuItem.Click += harianToolStripMenuItem_Click;
            // 
            // bulananToolStripMenuItem
            // 
            bulananToolStripMenuItem.Name = "bulananToolStripMenuItem";
            bulananToolStripMenuItem.Size = new Size(224, 26);
            bulananToolStripMenuItem.Text = "Bulanan";
            bulananToolStripMenuItem.Click += bulananToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { status });
            statusStrip.Location = new Point(0, 645);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(1296, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // status
            // 
            status.Name = "status";
            status.Size = new Size(49, 20);
            status.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei UI", 18F);
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 4;
            label1.Text = "Jumlah Saldo :";
            // 
            // saldo
            // 
            saldo.AutoSize = true;
            saldo.BackColor = Color.Transparent;
            saldo.Font = new Font("Microsoft JhengHei UI", 18F);
            saldo.Location = new Point(236, 82);
            saldo.Name = "saldo";
            saldo.RightToLeft = RightToLeft.No;
            saldo.Size = new Size(219, 38);
            saldo.TabIndex = 6;
            saldo.Text = "Rp. xxx.xxx.xxx";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei UI", 18F);
            label3.Location = new Point(13, 139);
            label3.Name = "label3";
            label3.Size = new Size(217, 38);
            label3.TabIndex = 7;
            label3.Text = "Stok Sampah :";
            // 
            // kacaBerat
            // 
            kacaBerat.AutoSize = true;
            kacaBerat.BackColor = Color.Transparent;
            kacaBerat.Font = new Font("Microsoft JhengHei UI", 13.8F);
            kacaBerat.Location = new Point(86, 584);
            kacaBerat.Name = "kacaBerat";
            kacaBerat.Size = new Size(43, 29);
            kacaBerat.TabIndex = 8;
            kacaBerat.Text = "XX";
            // 
            // kertasBerat
            // 
            kertasBerat.AutoSize = true;
            kertasBerat.BackColor = Color.Transparent;
            kertasBerat.Font = new Font("Microsoft JhengHei UI", 13.8F);
            kertasBerat.Location = new Point(743, 403);
            kertasBerat.Name = "kertasBerat";
            kertasBerat.Size = new Size(43, 29);
            kertasBerat.TabIndex = 9;
            kertasBerat.Text = "XX";
            // 
            // logamBerat
            // 
            logamBerat.AutoSize = true;
            logamBerat.BackColor = Color.Transparent;
            logamBerat.Font = new Font("Microsoft JhengHei UI", 13.8F);
            logamBerat.Location = new Point(409, 403);
            logamBerat.Name = "logamBerat";
            logamBerat.Size = new Size(43, 29);
            logamBerat.TabIndex = 10;
            logamBerat.Text = "XX";
            // 
            // plastikBerat
            // 
            plastikBerat.AutoSize = true;
            plastikBerat.BackColor = Color.Transparent;
            plastikBerat.Font = new Font("Microsoft JhengHei UI", 13.8F);
            plastikBerat.Location = new Point(86, 403);
            plastikBerat.Name = "plastikBerat";
            plastikBerat.Size = new Size(43, 29);
            plastikBerat.TabIndex = 11;
            plastikBerat.Text = "XX";
            // 
            // kainBerat
            // 
            kainBerat.AutoSize = true;
            kainBerat.BackColor = Color.Transparent;
            kainBerat.Font = new Font("Microsoft JhengHei UI", 13.8F);
            kainBerat.Location = new Point(409, 593);
            kainBerat.Name = "kainBerat";
            kainBerat.Size = new Size(43, 29);
            kainBerat.TabIndex = 12;
            kainBerat.Text = "XX";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label9.Location = new Point(670, 593);
            label9.Name = "label9";
            label9.Size = new Size(0, 29);
            label9.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = properties.Resources._2_removebg_preview__1_;
            pictureBox2.Location = new Point(55, 293);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = properties.Resources._6_removebg_preview__1_;
            pictureBox3.Location = new Point(356, 501);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(145, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = properties.Resources._4_removebg_preview__1_;
            pictureBox4.Location = new Point(693, 302);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(137, 98);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = properties.Resources._7_removebg_preview__1_;
            pictureBox5.Location = new Point(693, 501);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(147, 89);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = properties.Resources._3_removebg_preview__1_;
            pictureBox6.Location = new Point(373, 302);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(125, 98);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 33;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = properties.Resources._5_removebg_preview__1_;
            pictureBox7.Location = new Point(65, 501);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(108, 80);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 34;
            pictureBox7.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label16.Location = new Point(31, 261);
            label16.Name = "label16";
            label16.Size = new Size(82, 29);
            label16.TabIndex = 36;
            label16.Text = "Plastik";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label17.Location = new Point(343, 261);
            label17.Name = "label17";
            label17.Size = new Size(89, 29);
            label17.TabIndex = 37;
            label17.Text = "Logam";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label18.Location = new Point(682, 261);
            label18.Name = "label18";
            label18.Size = new Size(80, 29);
            label18.TabIndex = 38;
            label18.Text = "Kertas";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label19.Location = new Point(682, 469);
            label19.Name = "label19";
            label19.Size = new Size(70, 29);
            label19.TabIndex = 41;
            label19.Text = "Karet";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label20.Location = new Point(340, 469);
            label20.Name = "label20";
            label20.Size = new Size(60, 29);
            label20.TabIndex = 40;
            label20.Text = "Kain";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Microsoft JhengHei UI", 13.8F);
            label21.Location = new Point(43, 469);
            label21.Name = "label21";
            label21.Size = new Size(64, 29);
            label21.TabIndex = 39;
            label21.Text = "Kaca";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Image = properties.Resources._1_removebg_preview__1_;
            pictureBox8.Location = new Point(1122, 62);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(134, 189);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 43;
            pictureBox8.TabStop = false;
            // 
            // karetBerat
            // 
            karetBerat.AutoSize = true;
            karetBerat.BackColor = Color.Transparent;
            karetBerat.Font = new Font("Microsoft JhengHei UI", 13.8F);
            karetBerat.Location = new Point(743, 602);
            karetBerat.Name = "karetBerat";
            karetBerat.Size = new Size(43, 29);
            karetBerat.TabIndex = 45;
            karetBerat.Text = "XX";
            // 
            // menuUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1296, 671);
            Controls.Add(karetBerat);
            Controls.Add(pictureBox8);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label9);
            Controls.Add(kainBerat);
            Controls.Add(plastikBerat);
            Controls.Add(logamBerat);
            Controls.Add(kertasBerat);
            Controls.Add(kacaBerat);
            Controls.Add(label3);
            Controls.Add(saldo);
            Controls.Add(label1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "menuUtama";
            Text = "menuUtama";
            Load += menuUtama_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem setorSampahToolStripMenuItem;
        private ToolStripMenuItem transaksiLainnyaToolStripMenuItem;
        private ToolStripMenuItem updateDataToolStripMenuItem;
        private ToolStripMenuItem laporanToolStripMenuItem;
        private Label label1;
        private Label saldo;
        private Label label3;
        private Label kacaBerat;
        private Label kertasBerat;
        private Label logamBerat;
        private Label plastikBerat;
        private Label kainBerat;
        private Label label9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private PictureBox pictureBox8;
        private ToolStripMenuItem harianToolStripMenuItem;
        private ToolStripMenuItem bulananToolStripMenuItem;
        private Label karetBerat;
    }
}



