namespace moneyNtrash.GUI
{
    partial class pilihHari
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
            daySelector = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // daySelector
            // 
            daySelector.Location = new Point(90, 102);
            daySelector.Name = "daySelector";
            daySelector.Size = new Size(278, 27);
            daySelector.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(179, 163);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Konfirmasi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pilihHari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 238);
            Controls.Add(button1);
            Controls.Add(daySelector);
            Name = "pilihHari";
            Text = "pilihHari";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker daySelector;
        private Button button1;
    }
}