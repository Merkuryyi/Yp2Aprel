using  Npgsql;
namespace laba26
{
    public class connectDatabase
    {
        public static NpgsqlConnection GetSqlConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Host=localhost;Username=postgres;Password=qwerty;Database=postgres");
            conn.Open();
            return conn;
        }
    }
}