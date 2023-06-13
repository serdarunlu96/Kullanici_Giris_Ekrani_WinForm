namespace Kullanici_Giris_Ekrani_WinForm
{
    partial class Form2
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
            lblKarsilama = new Label();
            SuspendLayout();
            // 
            // lblKarsilama
            // 
            lblKarsilama.AutoSize = true;
            lblKarsilama.Location = new Point(26, 19);
            lblKarsilama.Name = "lblKarsilama";
            lblKarsilama.Size = new Size(0, 15);
            lblKarsilama.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 55);
            Controls.Add(lblKarsilama);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblKarsilama;
    }
}