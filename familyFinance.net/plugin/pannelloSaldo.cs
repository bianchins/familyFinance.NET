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
    public partial class pannelloSaldo : UserControl
    {
        public pannelloSaldo()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            libreria.connettiSqlite();
            double saldo = 0;
            libreria.leggi_saldo(out saldo);
            lbl_saldo.Text = "Saldo attuale: "+saldo.ToString("0.00") + "€";
        }
    }
}
