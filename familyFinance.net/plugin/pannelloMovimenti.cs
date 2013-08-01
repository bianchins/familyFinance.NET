using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using familyFinance.net.library;

namespace familyFinance.net.plugin
{
    public partial class pannelloMovimenti : UserControl
    {
        public pannelloMovimenti()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            dataInizio.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dataFine.Value = new DateTime(DateTime.Now.Year, 12, 31);
            aggiorna();
        }

        public void aggiorna()
        {
            grigliaMovimenti.Rows.Clear();
            libreria.connettiSqlite();
            List<movimento> listaMovimenti = new List<movimento>();
            libreria.leggi_movimenti(out listaMovimenti, dataInizio.Value, dataFine.Value);
            foreach (movimento m in listaMovimenti)
            {
                string[] riga_da_inserire = new string[5];
                riga_da_inserire[0] = m.data.ToShortDateString();
                riga_da_inserire[1] = m.importo.ToString("0.00") + " €";
                riga_da_inserire[2] = m.categoria;
                riga_da_inserire[3] = m.descrizione;
                riga_da_inserire[4] = m.note;
                int riga_inserita = grigliaMovimenti.Rows.Add(riga_da_inserire);
                grigliaMovimenti.Rows[riga_inserita].Tag = m;
                grigliaMovimenti.Rows[riga_inserita].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (m.importo < 0) grigliaMovimenti.Rows[riga_inserita].Cells[1].Style.ForeColor = Color.Red;
                else grigliaMovimenti.Rows[riga_inserita].Cells[1].Style.ForeColor = Color.Lime;
            }
            grigliaMovimenti.ClearSelection();
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
 
            dialog.dialogInserisciMovimento finestraInserimento = new dialog.dialogInserisciMovimento();
            finestraInserimento.ShowDialog();
            aggiorna();
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (grigliaMovimenti.SelectedRows.Count > 0)
            {
                movimento m = (movimento)grigliaMovimenti.SelectedRows[0].Tag;
                libreria.elimina_movimento(m.id_movimento);
                aggiorna();
            }
        }

        private void grigliaMovimenti_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Elimino il movimento?","Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                movimento m = (movimento)e.Row.Tag;
                libreria.elimina_movimento(m.id_movimento);
            }
            else e.Cancel = true;
        }

        private void dataInizio_ValueChanged(object sender, EventArgs e)
        {
            aggiorna();
        }

        private void dataFine_ValueChanged(object sender, EventArgs e)
        {
            aggiorna();
        }

        private void btn_modifica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funzione non ancora implementata");
        }

        private void btn_importa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funzione non ancora implementata");
        }

    }
}
