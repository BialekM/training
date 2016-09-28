using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.HornetsTraining.Training2.HomeWork
{
    public class PlusBankSQLiteClient
    {
        private SQLiteConnection conn;

        public bool connected { get { return conn.State == ConnectionState.Open ? true : false; } private set { } }

        public PlusBankSQLiteClient(string dbName = "plusbank.sqlite")
        {
            //  SQLiteConnection.CreateFile(dbName);
            conn = new SQLiteConnection("Data Source='" + dbName + "'");
            
        }

        public void Connect()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                conn.Open();
        }

        public void Query(string query)
        {
            Connect();

            SQLiteCommand command = new SQLiteCommand(query, conn);
            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}
