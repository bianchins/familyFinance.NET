using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace familyFinance.net.plugin
{
    public partial class pannelloOpzioni : UserControl
    {
        public pannelloOpzioni()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void pannelloOpzioni_Load(object sender, EventArgs e)
        {
            txt_saldo.Text = Properties.Settings.Default.saldoIniziale.ToString("0.00");
            txt_intestatario.Text = Properties.Settings.Default.intestatario;
        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.saldoIniziale = double.Parse(txt_saldo.Text.Replace('.',','));
                Properties.Settings.Default.intestatario = txt_intestatario.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Il saldo deve essere un numero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
