namespace moneyNtrash.GUI
{
    partial class updateData
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
            namaSampah = new Label();
            label3 = new Label();
            button1 = new Button();
            harga = new NumericUpDown();
            label1 = new Label();
            stok = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)harga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stok).BeginInit();
            SuspendLayout();
            // 
            // namaSampah
            // 
            namaSampah.AutoSize = true;
            namaSampah.Location = new Point(37, 27);
            namaSampah.Name = "namaSampah";
            namaSampah.Size = new Size(102, 20);
            namaSampah.TabIndex = 0;
            namaSampah.Text = "nama sampah";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 90);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Harga Baru (Rp)";
            // 
            // button1
            // 
            button1.Location = new Point(162, 193);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 5;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // harga
            // 
            harga.Location = new Point(37, 113);
            harga.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            harga.Name = "harga";
            harga.Size = new Size(150, 27);
            harga.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 90);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 7;
            label1.Text = "Stok Baru (Kg)";
            // 
            // stok
            // 
            stok.Location = new Point(261, 113);
            stok.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            stok.Name = "stok";
            stok.Size = new Size(150, 27);
            stok.TabIndex = 9;
            // 
            // updateData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 306);
            Controls.Add(stok);
            Controls.Add(label1);
            Controls.Add(harga);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(namaSampah);
            Name = "updateData";
            Text = "updateHarga";
            ((System.ComponentModel.ISupportInitialize)harga).EndInit();
            ((System.ComponentModel.ISupportInitialize)stok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label namaSampah;
        private Label label3;
        private Button button1;
        private NumericUpDown harga;
        private Label label1;
        private NumericUpDown stok;
    }
}