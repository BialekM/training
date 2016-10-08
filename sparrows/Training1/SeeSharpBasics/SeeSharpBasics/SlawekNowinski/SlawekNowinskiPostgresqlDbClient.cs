using Npgsql;
using SeeSharpBasics.Training4.Db;

namespace SeeSharpBasics.SlawekNowinski
{
    public class SlawekNowinskiPostgresqlDbClient : PostgresqlDbClient
    {
        public override bool Update(string query)
        {
            Connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(query);
            command.Connection = Connection;

            command.ExecuteNonQuery();

            Connection.Close();

            return true;
        }

        public override bool Delete(string query)
        {
            Connection.Open();

            NpgsqlCommand command = new NpgsqlCommand(query);
            command.Connection = Connection;

            command.ExecuteNonQuery();

            Connection.Close();

            return true;
        }
    }
}