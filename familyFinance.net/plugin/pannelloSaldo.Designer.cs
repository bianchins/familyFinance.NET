namespace familyFinance.net.plugin
{
    partial class pannelloSaldo
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_credits = new System.Windows.Forms.Label();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(160, 111);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(35, 13);
            this.lbl_saldo.TabIndex = 0;
            this.lbl_saldo.Text = "label1";
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.Controls.Add(this.lbl_titolo);
            this.top_panel.Controls.Add(this.pictureBox2);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(579, 39);
            this.top_panel.TabIndex = 9;
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(53, 8);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(63, 23);
            this.lbl_titolo.TabIndex = 1;
            this.lbl_titolo.Text = "Saldo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::familyFinance.net.Properties.Resources.gold;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::familyFinance.net.Properties.Resources.gold2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_credits
            // 
            this.lbl_credits.AutoSize = true;
            this.lbl_credits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_credits.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_credits.Location = new System.Drawing.Point(0, 348);
            this.lbl_credits.Name = "lbl_credits";
            this.lbl_credits.Size = new System.Drawing.Size(356, 13);
            this.lbl_credits.TabIndex = 10;
            this.lbl_credits.Text = "familyFinance.NET è un software di prova sviluppato da Stefano Bianchini";
            // 
            // pannelloSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_credits);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_saldo);
            this.Name = "pannelloSaldo";
            this.Size = new System.Drawing.Size(579, 361);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_credits;
    }
}
