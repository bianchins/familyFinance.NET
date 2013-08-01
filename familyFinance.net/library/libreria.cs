using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace familyFinance.net.library
{
    public static class libreria
    {
        private static string connString = "Data Source = familyFinance.sqlite; Version=3;";
        private static SQLiteConnection conn = new SQLiteConnection(connString);

        public static bool connettiSqlite()
        {
            try
            {
             if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            }
            catch (SQLiteException sqlex) 
            { 
                return false; 
            }
            return true;
        }

        public static bool chiudiSqlite()
        {
            try
            {
                conn.Close();
            }
            catch (SQLiteException sqlex)
            {
                return false;
            }
            return true;
        }

        public static void leggi_saldo(out double saldo)
        {
            connettiSqlite();
            saldo = Properties.Settings.Default.saldoIniziale;
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "select importo from movimenti";
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string s = reader.GetValue(0).ToString();
                    saldo += Double.Parse(s);
                }
                reader.Close();
            }
            else
            {
                saldo = 0;
            }
        }

        public static void leggi_entrate(out double entrate)
        {
            connettiSqlite();
            entrate = 0;
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "select importo from movimenti where importo > 0";
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string s = reader.GetValue(0).ToString();
                    entrate += Double.Parse(s);
                }
                reader.Close();
            }
            else
            {
                entrate = 0;
            }
        }

        public static void leggi_uscite(out double uscite)
        {
            connettiSqlite();
            uscite = 0;
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "select importo from movimenti where importo < 0";
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string s = reader.GetValue(0).ToString();
                    uscite += Double.Parse(s);
                }
                reader.Close();
            }
            else
            {
                uscite = 0;
            }
        }

        public static void leggi_movimenti(out List<movimento> listaMovimenti, DateTime datainizio, DateTime datafine)
        {
            connettiSqlite();
            listaMovimenti = new List<movimento>();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "select id_movimento,data,importo,descrizione,categoria,note from movimenti where DATE(data) >= DATE(@datainizio) AND DATE(data) <= DATE(@datafine)";
            cmd.Parameters.Add("@datainizio", System.Data.DbType.DateTime);
            cmd.Parameters["@datainizio"].Value = datainizio;
            cmd.Parameters.Add("@datafine", System.Data.DbType.DateTime);
            cmd.Parameters["@datafine"].Value = datafine;
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id_movimento = reader.GetInt32(0);
                    DateTime data = reader.GetDateTime(1);
                    double importo = reader.GetDouble(2);
                    string descrizione = reader.GetString(3);
                    listaMovimenti.Add(new movimento(id_movimento,descrizione,data,importo,"",""));
                }
                reader.Close();
            }
        }

        public static void elimina_movimento(int id_movimento)
        {
            connettiSqlite();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "DELETE FROM movimenti WHERE id_movimento=@id_movimento";
                cmd.Parameters.Add("@id_movimento", System.Data.DbType.Int32);
                cmd.Parameters["@id_movimento"].Value = id_movimento;
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException sqlex) { }
        }

        public static void inserisci_movimento(movimento movimento_da_inserire)
        {
            connettiSqlite();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "INSERT INTO movimenti(data,importo,descrizione,categoria,note) VALUES (@data, @importo,@descrizione,@categoria,@note)";
                cmd.Parameters.Add("@data", System.Data.DbType.Date);
                cmd.Parameters["@data"].Value = movimento_da_inserire.data;
                cmd.Parameters.Add("@importo", System.Data.DbType.Double);
                cmd.Parameters["@importo"].Value = movimento_da_inserire.importo;
                cmd.Parameters.Add("@descrizione", System.Data.DbType.String);
                cmd.Parameters["@descrizione"].Value = movimento_da_inserire.descrizione;
                cmd.Parameters.Add("@categoria", System.Data.DbType.String);
                cmd.Parameters["@categoria"].Value = movimento_da_inserire.categoria;
                cmd.Parameters.Add("@note", System.Data.DbType.String);
                cmd.Parameters["@note"].Value = movimento_da_inserire.note;
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException sqlex) { }
        }

    }
}
