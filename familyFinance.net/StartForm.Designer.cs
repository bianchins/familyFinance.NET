namespace familyFinance.net
{
    partial class StartForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Saldo", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Movimenti", 4, 4);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Statistiche", 9, 9);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Opzioni", 8, 8);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.albero_navigazione = new System.Windows.Forms.TreeView();
            this.listaImmagini = new System.Windows.Forms.ImageList(this.components);
            this.lbl_statusbar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_statusbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.albero_navigazione);
            this.splitContainer1.Size = new System.Drawing.Size(846, 499);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.TabStop = false;
            // 
            // albero_navigazione
            // 
            this.albero_navigazione.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albero_navigazione.FullRowSelect = true;
            this.albero_navigazione.ImageIndex = 0;
            this.albero_navigazione.ImageList = this.listaImmagini;
            this.albero_navigazione.Indent = 35;
            this.albero_navigazione.ItemHeight = 32;
            this.albero_navigazione.Location = new System.Drawing.Point(0, 0);
            this.albero_navigazione.Name = "albero_navigazione";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "nodo_saldo";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Saldo";
            treeNode2.ImageIndex = 4;
            treeNode2.Name = "nodo_movimenti";
            treeNode2.SelectedImageIndex = 4;
            treeNode2.Text = "Movimenti";
            treeNode3.ImageIndex = 9;
            treeNode3.Name = "nodo_statistiche";
            treeNode3.SelectedImageIndex = 9;
            treeNode3.Text = "Statistiche";
            treeNode4.ImageIndex = 8;
            treeNode4.Name = "nodo_opzioni";
            treeNode4.SelectedImageIndex = 8;
            treeNode4.Text = "Opzioni";
            this.albero_navigazione.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.albero_navigazione.SelectedImageIndex = 7;
            this.albero_navigazione.ShowRootLines = false;
            this.albero_navigazione.Size = new System.Drawing.Size(144, 495);
            this.albero_navigazione.TabIndex = 0;
            this.albero_navigazione.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.albero_navigazione_NodeMouseDoubleClick);
            // 
            // listaImmagini
            // 
            this.listaImmagini.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImmagini.ImageStream")));
            this.listaImmagini.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImmagini.Images.SetKeyName(0, "gold2.png");
            this.listaImmagini.Images.SetKeyName(1, "gold.png");
            this.listaImmagini.Images.SetKeyName(2, "list.png");
            this.listaImmagini.Images.SetKeyName(3, "Money.png");
            this.listaImmagini.Images.SetKeyName(4, "money_icon.png");
            this.listaImmagini.Images.SetKeyName(5, "money_icon_64.png");
            this.listaImmagini.Images.SetKeyName(6, "table_money.png");
            this.listaImmagini.Images.SetKeyName(7, "familyfinance.ico");
            this.listaImmagini.Images.SetKeyName(8, "opzioni.png");
            this.listaImmagini.Images.SetKeyName(9, "graph.png");
            // 
            // lbl_statusbar
            // 
            this.lbl_statusbar.Name = "lbl_statusbar";
            this.lbl_statusbar.Size = new System.Drawing.Size(0, 17);
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(846, 521);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "familyFinance.NET";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView albero_navigazione;
        private System.Windows.Forms.ImageList listaImmagini;
        private System.Windows.Forms.ToolStripStatusLabel lbl_statusbar;

    }
}

