namespace familyFinance.net.dialog
{
    partial class dialogInserisciMovimento
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogInserisciMovimento));
            this.top_panel = new System.Windows.Forms.Panel();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.txt_descrizione = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.txt_importo = new System.Windows.Forms.TextBox();
            this.data_scelta = new System.Windows.Forms.DateTimePicker();
            this.lbl_note = new System.Windows.Forms.Label();
            this.lbl_descrizione = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_importo = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.listaImmagini = new System.Windows.Forms.ImageList(this.components);
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.Controls.Add(this.lbl_titolo);
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(493, 39);
            this.top_panel.TabIndex = 9;
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(53, 8);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(206, 23);
            this.lbl_titolo.TabIndex = 1;
            this.lbl_titolo.Text = "Inserisci movimento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::familyFinance.net.Properties.Resources.money_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(36, 102);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(423, 20);
            this.txt_categoria.TabIndex = 10;
            // 
            // txt_descrizione
            // 
            this.txt_descrizione.Location = new System.Drawing.Point(36, 141);
            this.txt_descrizione.Name = "txt_descrizione";
            this.txt_descrizione.Size = new System.Drawing.Size(423, 20);
            this.txt_descrizione.TabIndex = 11;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(36, 180);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(423, 86);
            this.txt_note.TabIndex = 12;
            // 
            // txt_importo
            // 
            this.txt_importo.Location = new System.Drawing.Point(36, 63);
            this.txt_importo.Name = "txt_importo";
            this.txt_importo.Size = new System.Drawing.Size(83, 20);
            this.txt_importo.TabIndex = 13;
            // 
            // data_scelta
            // 
            this.data_scelta.Location = new System.Drawing.Point(259, 62);
            this.data_scelta.Name = "data_scelta";
            this.data_scelta.Size = new System.Drawing.Size(200, 20);
            this.data_scelta.TabIndex = 14;
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_note.Location = new System.Drawing.Point(33, 164);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(30, 13);
            this.lbl_note.TabIndex = 15;
            this.lbl_note.Text = "Note";
            // 
            // lbl_descrizione
            // 
            this.lbl_descrizione.AutoSize = true;
            this.lbl_descrizione.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_descrizione.Location = new System.Drawing.Point(33, 125);
            this.lbl_descrizione.Name = "lbl_descrizione";
            this.lbl_descrizione.Size = new System.Drawing.Size(62, 13);
            this.lbl_descrizione.TabIndex = 16;
            this.lbl_descrizione.Text = "Descrizione";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_categoria.Location = new System.Drawing.Point(33, 86);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(52, 13);
            this.lbl_categoria.TabIndex = 17;
            this.lbl_categoria.Text = "Categoria";
            // 
            // lbl_importo
            // 
            this.lbl_importo.AutoSize = true;
            this.lbl_importo.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_importo.Location = new System.Drawing.Point(33, 47);
            this.lbl_importo.Name = "lbl_importo";
            this.lbl_importo.Size = new System.Drawing.Size(42, 13);
            this.lbl_importo.TabIndex = 18;
            this.lbl_importo.Text = "Importo";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_data.Location = new System.Drawing.Point(256, 46);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(30, 13);
            this.lbl_data.TabIndex = 19;
            this.lbl_data.Text = "Data";
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_euro.Location = new System.Drawing.Point(125, 66);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(13, 13);
            this.lbl_euro.TabIndex = 20;
            this.lbl_euro.Text = "€";
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.ImageIndex = 1;
            this.btn_aggiungi.ImageList = this.listaImmagini;
            this.btn_aggiungi.Location = new System.Drawing.Point(363, 280);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(96, 35);
            this.btn_aggiungi.TabIndex = 21;
            this.btn_aggiungi.Text = "Aggiungi";
            this.btn_aggiungi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aggiungi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // listaImmagini
            // 
            this.listaImmagini.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImmagini.ImageStream")));
            this.listaImmagini.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImmagini.Images.SetKeyName(0, "icona_refresh.png");
            this.listaImmagini.Images.SetKeyName(1, "icona_aggiungi.gif");
            this.listaImmagini.Images.SetKeyName(2, "icona_calendario.png");
            this.listaImmagini.Images.SetKeyName(3, "icona_cerca.gif");
            this.listaImmagini.Images.SetKeyName(4, "icona_elimina.gif");
            this.listaImmagini.Images.SetKeyName(5, "icona_errore.gif");
            this.listaImmagini.Images.SetKeyName(6, "icona_importa.gif");
            this.listaImmagini.Images.SetKeyName(7, "icona_lucchetto.gif");
            this.listaImmagini.Images.SetKeyName(8, "icona_modifica.gif");
            this.listaImmagini.Images.SetKeyName(9, "icona_ok.png");
            this.listaImmagini.Images.SetKeyName(10, "icona_pollice_giu.gif");
            this.listaImmagini.Images.SetKeyName(11, "icona_pollice_su.gif");
            // 
            // dialogInserisciMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 320);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_importo);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_descrizione);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.data_scelta);
            this.Controls.Add(this.txt_importo);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_descrizione);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dialogInserisciMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserisci Movimento";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.TextBox txt_descrizione;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.TextBox txt_importo;
        private System.Windows.Forms.DateTimePicker data_scelta;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label lbl_descrizione;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label lbl_importo;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_euro;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.ImageList listaImmagini;
    }
}