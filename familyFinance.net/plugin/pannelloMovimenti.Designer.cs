namespace familyFinance.net.plugin
{
    partial class pannelloMovimenti
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pannelloMovimenti));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_data_a = new System.Windows.Forms.Label();
            this.lbl_data_da = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_importa = new System.Windows.Forms.Button();
            this.listaImmagini = new System.Windows.Forms.ImageList(this.components);
            this.btn_elimina = new System.Windows.Forms.Button();
            this.btn_modifica = new System.Windows.Forms.Button();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.dataFine = new System.Windows.Forms.DateTimePicker();
            this.dataInizio = new System.Windows.Forms.DateTimePicker();
            this.grigliaMovimenti = new System.Windows.Forms.DataGridView();
            this.colonna_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonna_importo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonna_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonna_descrizione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonna_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaMovimenti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_data_a);
            this.panel1.Controls.Add(this.lbl_data_da);
            this.panel1.Controls.Add(this.top_panel);
            this.panel1.Controls.Add(this.btn_importa);
            this.panel1.Controls.Add(this.btn_elimina);
            this.panel1.Controls.Add(this.btn_modifica);
            this.panel1.Controls.Add(this.btn_aggiungi);
            this.panel1.Controls.Add(this.dataFine);
            this.panel1.Controls.Add(this.dataInizio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 118);
            this.panel1.TabIndex = 0;
            // 
            // lbl_data_a
            // 
            this.lbl_data_a.AutoSize = true;
            this.lbl_data_a.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_data_a.Location = new System.Drawing.Point(326, 96);
            this.lbl_data_a.Name = "lbl_data_a";
            this.lbl_data_a.Size = new System.Drawing.Size(37, 13);
            this.lbl_data_a.TabIndex = 21;
            this.lbl_data_a.Text = "a data";
            // 
            // lbl_data_da
            // 
            this.lbl_data_da.AutoSize = true;
            this.lbl_data_da.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_data_da.Location = new System.Drawing.Point(42, 96);
            this.lbl_data_da.Name = "lbl_data_da";
            this.lbl_data_da.Size = new System.Drawing.Size(43, 13);
            this.lbl_data_da.TabIndex = 20;
            this.lbl_data_da.Text = "da data";
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.Controls.Add(this.lbl_titolo);
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(610, 39);
            this.top_panel.TabIndex = 8;
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(53, 8);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(164, 23);
            this.lbl_titolo.TabIndex = 1;
            this.lbl_titolo.Text = "Lista movimenti";
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
            // btn_importa
            // 
            this.btn_importa.ImageIndex = 6;
            this.btn_importa.ImageList = this.listaImmagini;
            this.btn_importa.Location = new System.Drawing.Point(114, 45);
            this.btn_importa.Name = "btn_importa";
            this.btn_importa.Size = new System.Drawing.Size(96, 35);
            this.btn_importa.TabIndex = 7;
            this.btn_importa.Text = "Importa";
            this.btn_importa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_importa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_importa.UseVisualStyleBackColor = true;
            this.btn_importa.Click += new System.EventHandler(this.btn_importa_Click);
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
            // btn_elimina
            // 
            this.btn_elimina.ImageIndex = 4;
            this.btn_elimina.ImageList = this.listaImmagini;
            this.btn_elimina.Location = new System.Drawing.Point(318, 45);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.Size = new System.Drawing.Size(96, 35);
            this.btn_elimina.TabIndex = 6;
            this.btn_elimina.Text = "Elimina";
            this.btn_elimina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_elimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_elimina.UseVisualStyleBackColor = true;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // btn_modifica
            // 
            this.btn_modifica.ImageIndex = 8;
            this.btn_modifica.ImageList = this.listaImmagini;
            this.btn_modifica.Location = new System.Drawing.Point(216, 45);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(96, 35);
            this.btn_modifica.TabIndex = 5;
            this.btn_modifica.Text = "Modifica";
            this.btn_modifica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_modifica.UseVisualStyleBackColor = true;
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.ImageIndex = 1;
            this.btn_aggiungi.ImageList = this.listaImmagini;
            this.btn_aggiungi.Location = new System.Drawing.Point(12, 45);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(96, 35);
            this.btn_aggiungi.TabIndex = 4;
            this.btn_aggiungi.Text = "Aggiungi";
            this.btn_aggiungi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_aggiungi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // dataFine
            // 
            this.dataFine.Location = new System.Drawing.Point(369, 92);
            this.dataFine.Name = "dataFine";
            this.dataFine.Size = new System.Drawing.Size(200, 20);
            this.dataFine.TabIndex = 3;
            this.dataFine.ValueChanged += new System.EventHandler(this.dataFine_ValueChanged);
            // 
            // dataInizio
            // 
            this.dataInizio.Location = new System.Drawing.Point(90, 92);
            this.dataInizio.Name = "dataInizio";
            this.dataInizio.Size = new System.Drawing.Size(200, 20);
            this.dataInizio.TabIndex = 2;
            this.dataInizio.ValueChanged += new System.EventHandler(this.dataInizio_ValueChanged);
            // 
            // grigliaMovimenti
            // 
            this.grigliaMovimenti.AllowUserToAddRows = false;
            this.grigliaMovimenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grigliaMovimenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonna_data,
            this.colonna_importo,
            this.colonna_categoria,
            this.colonna_descrizione,
            this.colonna_note});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grigliaMovimenti.DefaultCellStyle = dataGridViewCellStyle2;
            this.grigliaMovimenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grigliaMovimenti.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grigliaMovimenti.Location = new System.Drawing.Point(0, 118);
            this.grigliaMovimenti.Name = "grigliaMovimenti";
            this.grigliaMovimenti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grigliaMovimenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grigliaMovimenti.Size = new System.Drawing.Size(610, 264);
            this.grigliaMovimenti.TabIndex = 1;
            this.grigliaMovimenti.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grigliaMovimenti_UserDeletingRow);
            // 
            // colonna_data
            // 
            this.colonna_data.HeaderText = "Data";
            this.colonna_data.Name = "colonna_data";
            // 
            // colonna_importo
            // 
            this.colonna_importo.HeaderText = "Importo";
            this.colonna_importo.Name = "colonna_importo";
            // 
            // colonna_categoria
            // 
            this.colonna_categoria.HeaderText = "Categoria";
            this.colonna_categoria.Name = "colonna_categoria";
            // 
            // colonna_descrizione
            // 
            this.colonna_descrizione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colonna_descrizione.HeaderText = "Descrizione";
            this.colonna_descrizione.Name = "colonna_descrizione";
            // 
            // colonna_note
            // 
            this.colonna_note.HeaderText = "Note";
            this.colonna_note.Name = "colonna_note";
            // 
            // pannelloMovimenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grigliaMovimenti);
            this.Controls.Add(this.panel1);
            this.Name = "pannelloMovimenti";
            this.Size = new System.Drawing.Size(610, 382);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grigliaMovimenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grigliaMovimenti;
        private System.Windows.Forms.DateTimePicker dataFine;
        private System.Windows.Forms.DateTimePicker dataInizio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonna_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonna_importo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonna_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonna_descrizione;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonna_note;
        private System.Windows.Forms.Button btn_importa;
        private System.Windows.Forms.Button btn_elimina;
        private System.Windows.Forms.Button btn_modifica;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.ImageList listaImmagini;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_data_a;
        private System.Windows.Forms.Label lbl_data_da;
    }
}
