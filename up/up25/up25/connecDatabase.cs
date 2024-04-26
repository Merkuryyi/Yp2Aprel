using Npgsql;
using  System;
namespace up25
{
    public static class connecDatabase
    {
        public static NpgsqlConnection GetSqlConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Host=localhost;Username=postgres;Password=qwerty;Database=postgres");
            conn.Open();
            return conn;
        }
    }

}