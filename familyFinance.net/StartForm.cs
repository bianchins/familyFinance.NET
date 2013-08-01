using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using familyFinance.net.plugin;

/**
 * Tabella movimenti
 * id_movimento
 * data
 * importo
 * descrizione
 * categoria
 * note
 * */

namespace familyFinance.net
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void albero_navigazione_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Qui codice per caricare i plugin
            splitContainer1.Panel2.Controls.Clear();

            if(e.Node.Name.Equals("nodo_saldo"))
                splitContainer1.Panel2.Controls.Add(new pannelloSaldo());
            if (e.Node.Name.Equals("nodo_opzioni"))
                splitContainer1.Panel2.Controls.Add(new pannelloOpzioni());
            if (e.Node.Name.Equals("nodo_movimenti"))
                splitContainer1.Panel2.Controls.Add(new pannelloMovimenti());
            if (e.Node.Name.Equals("nodo_statistiche"))
                splitContainer1.Panel2.Controls.Add(new pannelloStatistiche());
        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            library.libreria.chiudiSqlite();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Add(new pannelloSaldo());
            lbl_statusbar.Text = "Benvenuto/a in familyFinance.NET 0.1, " + Properties.Settings.Default.intestatario;
        }
    }
}