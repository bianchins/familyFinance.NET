namespace familyFinance.net.plugin
{
    partial class pannelloOpzioni
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.top_panel = new System.Windows.Forms.Panel();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_intestatario = new System.Windows.Forms.TextBox();
            this.btn_salva = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo iniziale:";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(103, 69);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(44, 20);
            this.txt_saldo.TabIndex = 1;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.Controls.Add(this.lbl_titolo);
            this.top_panel.Controls.Add(this.pictureBox2);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(671, 39);
            this.top_panel.TabIndex = 10;
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(53, 8);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(83, 23);
            this.lbl_titolo.TabIndex = 1;
            this.lbl_titolo.Text = "Opzioni";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::familyFinance.net.Properties.Resources.opzioni;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Intestatario:";
            // 
            // txt_intestatario
            // 
            this.txt_intestatario.Location = new System.Drawing.Point(103, 99);
            this.txt_intestatario.Name = "txt_intestatario";
            this.txt_intestatario.Size = new System.Drawing.Size(135, 20);
            this.txt_intestatario.TabIndex = 13;
            // 
            // btn_salva
            // 
            this.btn_salva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salva.Image = global::familyFinance.net.Properties.Resources.icona_ok;
            this.btn_salva.Location = new System.Drawing.Point(557, 401);
            this.btn_salva.Name = "btn_salva";
            this.btn_salva.Size = new System.Drawing.Size(99, 38);
            this.btn_salva.TabIndex = 14;
            this.btn_salva.Text = "Salva";
            this.btn_salva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salva.UseVisualStyleBackColor = true;
            this.btn_salva.Click += new System.EventHandler(this.btn_salva_Click);
            // 
            // pannelloOpzioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_salva);
            this.Controls.Add(this.txt_intestatario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.label1);
            this.Name = "pannelloOpzioni";
            this.Size = new System.Drawing.Size(671, 452);
            this.Load += new System.EventHandler(this.pannelloOpzioni_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_intestatario;
        private System.Windows.Forms.Button btn_salva;
    }
}
