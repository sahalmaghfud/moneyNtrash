namespace moneyNtrash.GUI
{
    partial class pilihBulan
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
            monthSelector = new DateTimePicker();
            pilihButton = new Button();
            SuspendLayout();
            // 
            // monthSelector
            // 
            monthSelector.Format = DateTimePickerFormat.Custom;
            monthSelector.Location = new Point(179, 191);
            monthSelector.Name = "monthSelector";
            monthSelector.Size = new Size(166, 27);
            monthSelector.TabIndex = 0;
            // 
            // pilihButton
            // 
            pilihButton.Location = new Point(209, 253);
            pilihButton.Name = "pilihButton";
            pilihButton.Size = new Size(94, 29);
            pilihButton.TabIndex = 1;
            pilihButton.Text = "Oke";
            pilihButton.UseVisualStyleBackColor = true;
            pilihButton.Click += pilihButton_Click;
            // 
            // pilihBulan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 435);
            Controls.Add(pilihButton);
            Controls.Add(monthSelector);
            Name = "pilihBulan";
            Text = "dateSelector";
            ResumeLayout(false);
        }

        #endregion

        protected DateTimePicker monthSelector;
        private Button pilihButton;
    }
}