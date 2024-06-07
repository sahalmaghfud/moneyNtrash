namespace moneyNtrash.GUI
{
    partial class sampahSelector
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
            selectorr = new ComboBox();
            pilih = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // selectorr
            // 
            selectorr.FormattingEnabled = true;
            selectorr.Items.AddRange(new object[] { "plastik", "logam", "kertas ", "kaca", "kain", "karet" });
            selectorr.Location = new Point(103, 90);
            selectorr.Name = "selectorr";
            selectorr.Size = new Size(151, 28);
            selectorr.TabIndex = 0;
            // 
            // pilih
            // 
            pilih.Location = new Point(131, 136);
            pilih.Name = "pilih";
            pilih.Size = new Size(94, 29);
            pilih.TabIndex = 1;
            pilih.Text = "Pilih";
            pilih.UseVisualStyleBackColor = true;
            pilih.Click += pilih_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 54);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 2;
            label1.Text = "Pilih Jenis Sampah:";
            // 
            // sampahSelector
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 262);
            Controls.Add(label1);
            Controls.Add(pilih);
            Controls.Add(selectorr);
            Name = "sampahSelector";
            Text = "sampahSelector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectorr;
        private Button pilih;
        private Label label1;
    }
}