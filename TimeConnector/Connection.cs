using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeConnector
{
    public static class Connection
    {
        private static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                "Data Source=|DataDirectory|\\Database\\Time.accdb;" +
                                                "Jet OLEDB:Database Password=huck;";
        public static DataTable getResultTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                adapter.Dispose();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("DbError: " + e.Message + "");
            }
            return dt;
        }
        public static DataRow getResultRow(string query)
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            try
            {
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                dr = dt.Rows[0];
                adapter.Dispose();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("DbError: " + e.Message + "");
            }
            return dr;
        }
        public static void ExecuteQuery(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                OleDbConnection conn = new OleDbConnection(ConnectionString);
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
                adapter.Dispose();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("DbError: " + e.Message + "");
            }
        }
    }
}
