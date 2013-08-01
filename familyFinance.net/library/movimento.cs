using System;
using System.Collections.Generic;
using System.Text;

namespace familyFinance.net.library
{
    public class movimento
    {
        public DateTime data;
        public int id_movimento;
        public string descrizione;
        public string note;
        public string categoria;
        public double importo;

        public movimento(int id_movimento, string descrizione, DateTime data, double importo, string categoria, string note)
        {
            this.categoria = categoria;
            this.data = data;
            this.descrizione = descrizione;
            this.id_movimento = id_movimento;
            this.note = note;
            this.importo = importo;
        }

    }
}
