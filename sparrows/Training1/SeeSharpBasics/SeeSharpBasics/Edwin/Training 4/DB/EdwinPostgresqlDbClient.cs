using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SeeSharpBasics.Training4.Db;

namespace SeeSharpBasics.Edwin.Training_4.DB
{
    class EdwinPostgresqlDbClient : PostgresqlDbClient
    {

        protected NpgsqlConnection Connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=Ed_Database;User Id=postgres;Password = hasloToci;");


        public override bool Update(string query)
        {
            //client.Update("UPDATE toci SET telephone = '1111111' WHERE name = 'Romek'");
            //client.Update("UPDATE toci SET name = 'Jaroslaw', surname = 'Baczek' WHERE telephone = '1111111'");

            Connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();
            return true;
        }

        public override bool Delete(string query)
        {

            //client.Delete("DELETE from toci WHERE id = 28");
            //client.Delete("DELETE from toci WHERE name ='Janek'");

            Connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();
            return true;
        }

        public Hashtable[] Select(string query)
        {
            Connection.Open();
            NpgsqlCommand command = new NpgsqlCommand();

            command.Connection = Connection;
            NpgsqlDataReader reader = command.ExecuteReader();
            var columns = reader.GetColumnSchema();

            Hashtable[] table = new Hashtable[28];
            int i = 0;

            while (reader.Read())
            {

                Hashtable hash = new Hashtable();

                foreach (var column in columns)
                {
                    hash.Add(column.BaseColumnName, reader[column.BaseColumnName]);
                }
                table[i] = hash;
                i++;

            }
            Connection.Close();
            return null;
        }

        public int Insert(string query)
        {
            Connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(query);
            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();
            return 1;
        }
    }
}
