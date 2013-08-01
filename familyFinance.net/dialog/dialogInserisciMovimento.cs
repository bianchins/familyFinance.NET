using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using familyFinance.net.library;

namespace familyFinance.net.dialog
{
    public partial class dialogInserisciMovimento : Form
    {
        public dialogInserisciMovimento()
        {
            InitializeComponent();
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                libreria.inserisci_movimento(new movimento(0, txt_descrizione.Text, data_scelta.Value, double.Parse(txt_importo.Text), txt_categoria.Text, txt_note.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'importo deve essere un numero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}