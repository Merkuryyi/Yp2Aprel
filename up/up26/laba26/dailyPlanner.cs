using System;
using  Npgsql;
namespace laba26
{
    public class dailyPlanner
    {
        public static  void addTasks(string login)
        {
            var conn = connectDatabase.GetSqlConnection();
            Console.WriteLine("title: ");
            string title = Console.ReadLine();
            
            Console.WriteLine("description: ");
            string description = Console.ReadLine();
            
            Console.WriteLine("executeBefore: ");
            DateTime executeBefore = DateTime.Parse(Console.ReadLine());
            NpgsqlCommand command = new NpgsqlCommand(
                $"insert into task(login, title, description, executeBefore) values('{login}','{title}', '{description}', '{executeBefore}')", conn);
            command.ExecuteNonQuery();
          
          
        }
        public static void deleteTasks(string login)
        {
            var conn = connectDatabase.GetSqlConnection();
            Console.WriteLine("id: ");
            int id = int.Parse(Console.ReadLine());
            
            NpgsqlCommand command = new NpgsqlCommand(
                $"delete FROM task WHERE id = '{id}' and login = '{login}'", conn);
          command.ExecuteNonQuery();
        }
        
        
        public static void updateTasks(string login)
        {
            var conn = connectDatabase.GetSqlConnection();
            Console.WriteLine("id задачи, которую нужно изменить: ");
            int id = int.Parse(Console.ReadLine());
            
            Console.WriteLine("title: ");
            string title = Console.ReadLine();
            
            Console.WriteLine("description: ");
            string description = Console.ReadLine();
            
            Console.WriteLine("executeBefore: ");
            DateTime executeBefore = DateTime.Parse(Console.ReadLine());
            
            
            NpgsqlCommand command = new NpgsqlCommand(
                $"UPDATE task SET title = '{title}' , description = '{description}', executeBefore = '{executeBefore}' WHERE id = '{id}' and login = '{login}'", conn);
            command.ExecuteNonQuery();
           
            
            

        }
        
        public static void tasksTimeToday(string login)
        {
            var conn = connectDatabase.GetSqlConnection();
        
        
            NpgsqlCommand commandToday = new NpgsqlCommand(
                $"SELECT * FROM task where executeBefore = current_date and login = '{login}'", conn);

            Console.WriteLine("Заметки на сегодня");
            NpgsqlDataReader reader = commandToday .ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("id"));
             
                String title = reader.GetString(reader.GetOrdinal("title"));
                String description = reader.GetString(reader.GetOrdinal("description"));
                DateTime executeBefore  = reader.GetDateTime(reader.GetOrdinal("execute before"));
                Console.WriteLine("Id: {0}, title{3}, description{4}, execute before{5} ", id, title, description, executeBefore );
            }
            
        }


        public static void tasksTimeTomorrow(string login)
        {
            var conn = connectDatabase.GetSqlConnection();
            conn.Open();

            NpgsqlCommand commandTomorrow = new NpgsqlCommand(
                $"SELECT * FROM task where executeBefore = current_date + 1 and login = '{login}' ", conn);


            

            Console.WriteLine("Заметки на завтра");
            NpgsqlDataReader readerTomorrow = commandTomorrow.ExecuteReader();
            while (readerTomorrow.Read())
            {
                int id = readerTomorrow.GetInt32(readerTomorrow.GetOrdinal("id"));

                String title = readerTomorrow.GetString(readerTomorrow.GetOrdinal("title"));
                String description = readerTomorrow.GetString(readerTomorrow.GetOrdinal("description"));
                DateTime executeBefore = readerTomorrow.GetDateTime(readerTomorrow.GetOrdinal("executeBefore"));
                Console.WriteLine("Id: {0}, title{3}, description{4}, executeBefore{5} ", id, title, description,
                    executeBefore);
            }
        }
        public static void tasksTimeWeek(string login)
        {
            var conn = connectDatabase.GetSqlConnection();
            DateTime thisDay = DateTime.Today;

            int dayToday = (int)thisDay.DayOfWeek;

            DateTime sunday = thisDay.AddDays(7 - dayToday);
            DateTime monday = thisDay.AddDays(0 - dayToday + 1);
            
            NpgsqlCommand commandWeek = new NpgsqlCommand(
                $"SELECT * FROM task where executeBefore between (extract (dow from current_date)) and '{monday}' and login = '{login}' ", conn);

            
            Console.WriteLine("Заметки на неделю");
            NpgsqlDataReader readerWeek = commandWeek.ExecuteReader();
            while (readerWeek.Read())
            {
                int id = readerWeek.GetInt32(readerWeek.GetOrdinal("id"));

                String title = readerWeek.GetString(readerWeek.GetOrdinal("title"));
                String description = readerWeek.GetString(readerWeek.GetOrdinal("description"));
                DateTime executeBefore = readerWeek.GetDateTime(readerWeek.GetOrdinal("executeBefore"));
                Console.WriteLine("Id: {0}, title{3}, description{4}, executeBefore{5} ", id, title, description,
                    executeBefore);
            }
        }
        public static void tasksAll(string login)
        {
            var conn = connectDatabase.GetSqlConnection();

            NpgsqlCommand commandWeek = new NpgsqlCommand(
                $"SELECT * FROM task where login = '{login}' ", conn);

            NpgsqlDataReader readerWeek = commandWeek.ExecuteReader();
            while (readerWeek.Read())
            {
                int id = readerWeek.GetInt32(readerWeek.GetOrdinal("id"));

                String title = readerWeek.GetString(readerWeek.GetOrdinal("title"));
                String description = readerWeek.GetString(readerWeek.GetOrdinal("description"));
                DateTime executeBefore = readerWeek.GetDateTime(readerWeek.GetOrdinal("executeBefore"));
                Console.WriteLine("Id: {0}, title: {1}, description: {2}, executeBefore: {3} ", id, title, description,
                    executeBefore);
            }
        }
        public static void tasksPast(string login)
        {
            var conn = connectDatabase.GetSqlConnection();
            DateTime thisDay = DateTime.Parse("23/04/2024") ;

            NpgsqlCommand commandWeek = new NpgsqlCommand(
                $"SELECT * FROM task where executeBefore < '{thisDay}' and login = '{login}' ", conn);
            
            NpgsqlDataReader readerWeek = commandWeek.ExecuteReader();
            while (readerWeek.Read())
            {
                int id = readerWeek.GetInt32(readerWeek.GetOrdinal("id"));
                String title = readerWeek.GetString(readerWeek.GetOrdinal("title"));
                String description = readerWeek.GetString(readerWeek.GetOrdinal("description"));
                DateTime executeBefore = readerWeek.GetDateTime(readerWeek.GetOrdinal("executeBefore"));
                Console.WriteLine("Id: {0}, title: {1}, description: {2}, executeBefore: {3} ", id, title, description, executeBefore);
            }
        }
        public static void tasksUpcoming(string login)
        {
            var conn = connectDatabase.GetSqlConnection();

            NpgsqlCommand commandWeek = new NpgsqlCommand(
                $"SELECT * FROM task where executeBefore <  current_date  and login = '{login}' ", conn);
            
            NpgsqlDataReader readerWeek = commandWeek.ExecuteReader();
            while (readerWeek.Read())
            {
                int id = readerWeek.GetInt32(readerWeek.GetOrdinal("id"));

                String title = readerWeek.GetString(readerWeek.GetOrdinal("title"));
                String description = readerWeek.GetString(readerWeek.GetOrdinal("description"));
                DateTime executeBefore = readerWeek.GetDateTime(readerWeek.GetOrdinal("executeBefore"));
                Console.WriteLine("Id: {0}, title: {1}, description: {2}, executeBefore: {3} ", id, title, description, executeBefore);
            }
        }

        public static bool authorization(string login, string password)
        {
            var conn = connectDatabase.GetSqlConnection();
            

            NpgsqlCommand command = new NpgsqlCommand($"select * from users", conn);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string  log  = reader.GetString(reader.GetOrdinal("login"));
                string  pass  = reader.GetString(reader.GetOrdinal("password"));
                if (log == login && pass == password)
                {
                    return true;
                }
            }

            return false;
        }
        public static void registration(string login, string password)
        {
            var conn = connectDatabase.GetSqlConnection();
            NpgsqlCommand command = new NpgsqlCommand(
                $"insert into users(login, password) values('{login}','{password}')", conn);
            command.ExecuteNonQuery();
          
                Console.WriteLine("Готово");
            

        }
    }
}
