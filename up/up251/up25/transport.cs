namespace up25
{
    using Npgsql;
    using  System;
    
        public class transport
        {
            public static void getType_car()
            {
                var conn = connecDatabase.GetSqlConnection();
                NpgsqlCommand command = new NpgsqlCommand(
                    @"select * from type_car;", conn);

                NpgsqlDataReader reader1 = command.ExecuteReader();

                while (reader1.Read())
                {
                    int id = reader1.GetInt32(reader1.GetOrdinal("id"));
                    String name = reader1.GetString(reader1.GetOrdinal("name"));
                    Console.WriteLine("Id: {0}, name: {1}", id, name);
                }
                
            }
            public static void writeType_Car()
            {
                var conn = connecDatabase.GetSqlConnection();
                Console.WriteLine("id");
                int id = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Name");
                string names = Console.ReadLine();
              
                
                NpgsqlCommand command = new NpgsqlCommand(
                    $"  INSERT INTO type_car(id, name) VALUES ('{id}', '{names}')", conn);
               try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Готово");
                }
              
            }

            public static void getDriversAndRights()
            {
                var conn = connecDatabase.GetSqlConnection();
                NpgsqlCommand command1 = new NpgsqlCommand(
                    @"SELECT first_name, last_name, name
                    FROM driver_rights_category
                    INNER JOIN driver  on driver_rights_category.id_driver = driver.id
                    INNER JOIN rights_category  on rights_category.id = driver_rights_category.id_rights_category", conn);
         
                NpgsqlDataReader reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    String firstName = reader1.GetString(reader1.GetOrdinal("first_name"));
                    String lastName = reader1.GetString(reader1.GetOrdinal("last_name"));
                    String category = reader1.GetString(reader1.GetOrdinal("name"));
                    Console.WriteLine("First Name: {0}, Last Name: {1}, name: {2}", firstName, lastName, category);
                }
            }

            public static void writeDrivers()
            {
                var conn = connecDatabase.GetSqlConnection();
               
                Console.WriteLine("first-name");
                string first_name = Console.ReadLine();
                
                Console.WriteLine("last-name");
                string last_name = Console.ReadLine();
                
                Console.WriteLine("birthday");
                DateTime birthdate = DateTime.Parse(Console.ReadLine());
                
                Console.WriteLine("id");
                int id = int.Parse(Console.ReadLine());
               
                NpgsqlCommand command = new NpgsqlCommand(
                    $"INSERT INTO driver(id, first_name, last_name, birthdate) VALUES ('{id}', '{first_name}', '{last_name}', '{birthdate}');", conn);
                  
                try
                {
                    command.ExecuteNonQuery();
            
                }
                catch
                {
                    Console.WriteLine("Готово");
                }
           
            }

            public static void writeRightsForDriver()
            {
                var conn = connecDatabase.GetSqlConnection();
               
                Console.WriteLine("id_rights_category");
                int id_rights_categoru = int.Parse(Console.ReadLine());
                
                Console.WriteLine("id_driver");
                int id_driver = int.Parse(Console.ReadLine());
               
                NpgsqlCommand command = new NpgsqlCommand(
                    $"INSERT INTO driver_rights_category(id_driver, id_rights_category) VALUES ('{id_driver}', '{id_rights_categoru}')", conn);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Готово");
                }
            }
            
            public static void writeCar()
            {
                var conn = connecDatabase.GetSqlConnection();
               
                Console.WriteLine("id type car ");
                int id_type_car = int.Parse(Console.ReadLine());
                Console.WriteLine("name ");
                string name = Console.ReadLine();
                Console.WriteLine("unique state number");
                string state_number = Console.ReadLine();
                Console.WriteLine("number passengers");
                int number_passengers = int.Parse(Console.ReadLine());
                
                NpgsqlCommand command21 = new NpgsqlCommand(
                    $"INSERT INTO car( id_type_car, name, state_number, number_passengers) VALUES ('{id_type_car}', '{name}', '{state_number}', '{number_passengers}');", conn);
                try
                {
                    command21.ExecuteNonQuery();
                    
                }
                catch
                {
                    Console.WriteLine("Готово");
                }
            }

            public static void getCar()
            {
                var conn = connecDatabase.GetSqlConnection();
                NpgsqlCommand command1 = new NpgsqlCommand(
                    @"SELECT *  FROM car", conn);
                NpgsqlDataReader reader1 = command1 .ExecuteReader();
                while (reader1.Read())
                {
                    int id = reader1.GetInt32(reader1.GetOrdinal("id"));
                    int id_type_car = reader1.GetInt32(reader1.GetOrdinal("id_type_car"));
                    String name = reader1.GetString(reader1.GetOrdinal("name"));
                    String state_number = reader1.GetString(reader1.GetOrdinal("state_number"));
                    int number_passengers = reader1.GetInt32(reader1.GetOrdinal("number_passengers"));
                    Console.WriteLine("Id: {0},  id_type_car: {1}, name: {2}, state_number: {3}, number_passengers: {4}", id, id_type_car, name, state_number, number_passengers);
                }
            }
            public static void getRoute()
            {
                var conn = connecDatabase.GetSqlConnection();
                NpgsqlCommand command = new NpgsqlCommand(
                    @"SELECT *  FROM route", conn);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(reader.GetOrdinal("id"));
                    int id_driver = reader.GetInt32(reader.GetOrdinal("id_driver"));
                    int id_car = reader.GetInt32(reader.GetOrdinal("id_car"));
                    int id_itinerary = reader.GetInt32(reader.GetOrdinal("id_itinerary"));
                    int number_passengers = reader.GetInt32(reader.GetOrdinal("number_passengers"));
                    Console.WriteLine("id: {0},  id_driver: {1}, id_car: {2}, id_itinerary: {3}, number_passengers: {4}", id, id_driver , id_car , id_itinerary,  number_passengers);
                }
            }

            public static void getItinerary()
            {
                var conn = connecDatabase.GetSqlConnection();
                NpgsqlCommand command = new NpgsqlCommand(
                    @"SELECT *  FROM itinerary", conn);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(reader.GetOrdinal("id"));
                    String name = reader.GetString(reader.GetOrdinal("name"));
                    Console.WriteLine("Id: {0}, name: {1}", id,  name);
                }
            }
            public static void writeRote()
            {
                var conn = connecDatabase.GetSqlConnection();
                Console.WriteLine("id");
                int id = int.Parse(Console.ReadLine());
                
                Console.WriteLine("id_driver");
                int id_driver = int.Parse(Console.ReadLine());
                
                Console.WriteLine("id_car");
                int id_car = int.Parse(Console.ReadLine());
                
                Console.WriteLine("id_itinerary:");
                int id_itinerary = int.Parse(Console.ReadLine());
                
                Console.WriteLine("number_passengers:");
                int  number_passengers = int.Parse(Console.ReadLine());
                
                NpgsqlCommand command = new NpgsqlCommand(
                    $"INSERT INTO route(id, id_driver, id_car, id_itinerary, number_passengers) VALUES ('{id}', '{id_driver}', '{id_car}', '{id_itinerary}', '{number_passengers}');", conn);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Готово");
                }
            }

            public static void writeItinerary()
            {
                var conn = connecDatabase.GetSqlConnection();
                Console.WriteLine("id");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("name");
                string name = Console.ReadLine();


                NpgsqlCommand command1 = new NpgsqlCommand(
                    $"INSERT INTO itinerary(id, name) VALUES ('{id}', '{name}');", conn);
                try
                {
                    command1.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("Готово");
                }

            }
        }
    

}