namespace up25
{
    using Npgsql;
    using  System;
    public static class connecDatabase
    {
        public static NpgsqlConnection GetSqlConnection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(@"Host=localhost;Username=postgres;Password=62389trewq%Y;Database=postgres");
            conn.Open();
            return conn;
        }
    }
}