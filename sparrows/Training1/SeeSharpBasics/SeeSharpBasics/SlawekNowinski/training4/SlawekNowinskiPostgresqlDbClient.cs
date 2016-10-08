using Npgsql;
using SeeSharpBasics.Training4.Db;

namespace SeeSharpBasics.SlawekNowinski.training4
{
    public class SlawekNowinskiPostgresqlDbClient : PostgresqlDbClient
    {
        //NpgsqlConnection Connection = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=con_air;User Id=postgres;Password=qwerty;");
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